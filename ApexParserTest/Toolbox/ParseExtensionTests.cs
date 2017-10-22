﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexParser.MetaClass;
using ApexParser.Parser;
using ApexParser.Toolbox;
using NUnit.Framework;
using Sprache;
using static ApexParserTest.Properties.Resources;

namespace ApexParserTest.Toolbox
{
    [TestFixture]
    public class ParseExtensionTests : ICommentParserProvider
    {
        [Test]
        public void ParseExProducesMoreDetailedExceptionMessage()
        {
            // append the error line to the valid demo file
            var errorLine = "--===-- oops! --===--";
            var demo = Demo + Environment.NewLine + errorLine;

            try
            {
                new ApexGrammar().ClassDeclaration.End().ParseEx(demo);
                Assert.Fail("The code should have thrown ParseException.");
            }
            catch (ParseException ex)
            {
                // check that the error message contains the complete invalid code line
                var exc = ex as ParseExceptionCustom;
                Assert.NotNull(exc);
                Assert.True(exc.Apexcode.Contains(errorLine));
            }
        }

        private readonly Parser<string> Identifier1 =
            Parse.Identifier(Parse.Letter, Parse.LetterOrDigit).Token(null);

        [Test]
        public void ForStaticParserTokenNullModifierWorksLikeOrdinaryToken()
        {
            var result = Identifier1.Parse("    \t hello123   \t\r\n  ");
            Assert.AreEqual("hello123", result);
        }

        private CommentParser CommentParser { get; } = new CommentParser();

        public Parser<string> Comment => CommentParser.AnyComment;

        private Parser<string> Identifier2 =>
            Parse.Identifier(Parse.Letter, Parse.LetterOrDigit).Token(this);

        [Test]
        public void ForParserOwnedByICommentParserProviderTokenThisStripsOutComments()
        {
            // whitespace only
            var result = Identifier2.Parse("    \t hello123   \t\r\n  ");
            Assert.AreEqual("hello123", result);

            // trailing comments
            result = Identifier2.End().Parse("    \t hello123   // what's that? ");
            Assert.AreEqual("hello123", result);

            // leading and trailing comments
            result = Identifier2.Parse(@" // leading comments!
            helloWorld
            // trailing comments! ");
            Assert.AreEqual("helloWorld", result);

            // multiple leading and trailing comments
            result = Identifier2.Parse(@" // leading comments!

            /* multiline leading comments
            this is the second line */

            test321

            // trailing comments!
            /* --==-- */");
            Assert.AreEqual("test321", result);
        }

        private Parser<BreakStatementSyntax> BreakStatement1 =>
            from @break in Parse.IgnoreCase(ApexKeywords.Break).Token(this)
            from semicolon in Parse.Char(';').Token(this)
            select new BreakStatementSyntax();

        [Test]
        public void TokenThisModifierAppliedToPartsDoesntSaveCommentsContent()
        {
            // whitespace only
            var @break = BreakStatement1.Parse("    \t break;   \t\r\n  ");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(0, @break.TrailingComments.Count);

            // leading comments
            @break = BreakStatement1.Parse(@"
            // this is a break statement
            break;");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(0, @break.TrailingComments.Count);

            // trailing comments
            @break = BreakStatement1.Parse(@"
            break /* a comment before the semicolon */; // this is ignored");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(0, @break.TrailingComments.Count);
        }

        private Parser<BreakStatementSyntax> BreakStatement2 => (
            from @break in Parse.IgnoreCase(ApexKeywords.Break).Token(this)
            from semicolon in Parse.Char(';')
            select new BreakStatementSyntax()
        ).Token(this);

        [Test]
        public void TokenThisModifierAppliedToTheTopLevelParserSavesComments()
        {
            // whitespace only
            var @break = BreakStatement2.Parse("    \t break;   \t\r\n  ");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(0, @break.TrailingComments.Count);

            // leading comments
            @break = BreakStatement2.Parse(@"
            // this is a break statement
            break;");
            Assert.AreEqual(1, @break.LeadingComments.Count);
            Assert.AreEqual("this is a break statement", @break.LeadingComments[0].Trim());
            Assert.AreEqual(0, @break.TrailingComments.Count);

            // trailing comments
            @break = BreakStatement2.Parse(@"
            break /* this is ignored */; // a comment after the semicolon");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(1, @break.TrailingComments.Count);
            Assert.AreEqual("a comment after the semicolon", @break.TrailingComments[0].Trim());

            // both leading trailing comments
            @break = BreakStatement2.Parse(@"
            break /* this is ignored */; // a comment after the semicolon");
            Assert.AreEqual(0, @break.LeadingComments.Count);
            Assert.AreEqual(1, @break.TrailingComments.Count);
            Assert.AreEqual("a comment after the semicolon", @break.TrailingComments[0].Trim());
        }
    }
}
