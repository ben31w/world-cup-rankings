using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program360
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test1()
        {
            string[] input = new string[] {
                "World Cup 2010: Group A",
                "South Africa#1@1#Mexico",
                "Uruguay#0@0#France",
                "South Africa#0@3#Uruguay",
                "France#0@2#Mexico",
                "Mexico#0@1#Uruguay",
                "France#1@2#South Africa" 
            };
            string[] expected = new string[] {
                "World Cup 2010: Group A",
                "1) Uruguay 7p, 3g (2-1-0), 4gd (4-0)",
                "2) Mexico 4p, 3g (1-1-1), 1gd (3-2)",
                "3) South Africa 4p, 3g (1-1-1), -2gd (3-5)",
                "4) France 1p, 3g (0-1-2), -3gd (1-4)" 
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test2()
        {
            string[] input = new string[] {
                "World Cup 2010: Group B",
                "Argentina#1@0#Nigeria",
                "Korea Republic#2@0#Greece",
                "Greece#2@1#Nigeria",
                "Argentina#4@1#Korea Republic",
                "Nigeria#2@2#Korea Republic",
                "Greece#0@2#Argentina"
            };
            string[] expected = new string[] {
                "World Cup 2010: Group B",
                "1) Argentina 9p, 3g (3-0-0), 6gd (7-1)",
                "2) Korea Republic 4p, 3g (1-1-1), -1gd (5-6)",
                "3) Greece 3p, 3g (1-0-2), -3gd (2-5)",
                "4) Nigeria 1p, 3g (0-1-2), -2gd (3-5)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test3()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group B",
                "Argentina#1@0#Nigeria",
                "Korea Republic#2@0#Greece",
                "Greece#2@1#Nigeria",
                "Argentina#4@1#Korea Republic",
                "Nigeria#2@2#Korea Republic",
                "Greece#0@2#Argentina"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group B",
                "1) Argentina 9p, 3g (3-0-0), 6gd (7-1)",
                "2) Korea Republic 4p, 3g (1-1-1), -1gd (5-6)",
                "3) Greece 3p, 3g (1-0-2), -3gd (2-5)",
                "4) Nigeria 1p, 3g (0-1-2), -2gd (3-5)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test4()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group C",
                "England#1@1#USA",
                "Algeria#0@1#Slovenia",
                "Slovenia#2@2#USA",
                "England#0@0#Algeria",
                "Slovenia#0@1#England",
                "USA#1@0#Algeria"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group C",
                "1) USA 5p, 3g (1-2-0), 1gd (4-3)",
                "2) England 5p, 3g (1-2-0), 1gd (2-1)",
                "3) Slovenia 4p, 3g (1-1-1), 0gd (3-3)",
                "4) Algeria 1p, 3g (0-1-2), -2gd (0-2)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test5()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group D",
                "Germany#4@0#Australia",
                "Serbia#0@1#Ghana",
                "Germany#0@1#Serbia",
                "Ghana#1@1#Australia",
                "Ghana#0@1#Germany",
                "Australia#2@1#Serbia"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group D",
                "1) Germany 6p, 3g (2-0-1), 4gd (5-1)",
                "2) Ghana 4p, 3g (1-1-1), 0gd (2-2)",
                "3) Australia 4p, 3g (1-1-1), -3gd (3-6)",
                "4) Serbia 3p, 3g (1-0-2), -1gd (2-3)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test6()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group E",
		        "Netherlands#2@0#Denmark",
		        "Japan#1@0#Cameroon",
		        "Netherlands#1@0#Japan",
		        "Cameroon#1@2#Denmark",
		        "Denmark#1@3#Japan",
		        "Cameroon#1@2#Netherlands"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group E",
		        "1) Netherlands 9p, 3g (3-0-0), 4gd (5-1)",
		        "2) Japan 6p, 3g (2-0-1), 2gd (4-2)",
		        "3) Denmark 3p, 3g (1-0-2), -3gd (3-6)",
		        "4) Cameroon 0p, 3g (0-0-3), -3gd (2-5)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test7()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group F",
                "Italy#1@1#Paraguay",
                "New Zealand#1@1#Slovakia",
                "Slovakia#0@2#Paraguay",
                "Italy#1@1#New Zealand",
                "Slovakia#3@2#Italy",
                "Paraguay#0@0#New Zealand"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group F",
                "1) Paraguay 5p, 3g (1-2-0), 2gd (3-1)",
                "2) Slovakia 4p, 3g (1-1-1), -1gd (4-5)",
                "3) New Zealand 3p, 3g (0-3-0), 0gd (2-2)",
                "4) Italy 2p, 3g (0-2-1), -1gd (4-5)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test8()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group G",
                "Cote d'Ivoire#0@0#Portugal",
                "Brazil#2@1#Korea DPR",
                "Brazil#3@1#Cote d'Ivoire",
                "Portugal#7@0#Korea DPR",
                "Portugal#0@0#Brazil",
                "Korea DPR#0@3#Cote d'Ivoire"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group G",
                "1) Brazil 7p, 3g (2-1-0), 3gd (5-2)",
                "2) Portugal 5p, 3g (1-2-0), 7gd (7-0)",
                "3) Cote d'Ivoire 4p, 3g (1-1-1), 1gd (4-3)",
                "4) Korea DPR 0p, 3g (0-0-3), -11gd (1-12)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test9()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group H",
                "Honduras#0@1#Chile",
                "Spain#0@1#Switzerland",
                "Chile#1@0#Switzerland",
                "Spain#2@0#Honduras",
                "Chile#1@2#Spain",
                "Switzerland#0@0#Honduras"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group H",
                "1) Spain 6p, 3g (2-0-1), 2gd (4-2)",
                "2) Chile 6p, 3g (2-0-1), 1gd (3-2)",
                "3) Switzerland 4p, 3g (1-1-1), 0gd (1-1)",
                "4) Honduras 1p, 3g (0-1-2), -3gd (0-3)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test10()
        {
            string[] input = new string[] {
		        "World Cup 2010: Group G",
                "Cote d'Ivoire#0@0#Portugal",
                "Brazil#2@1#Korea DPR",
                "Brazil#3@1#Cote d'Ivoire",
                "Portugal#7@0#Korea DPR",
                "Portugal#0@0#Brazil",
                "Korea DPR#0@3#Cote d'Ivoire"
            };
            string[] expected = new string[] {
		        "World Cup 2010: Group G",
                "1) Brazil 7p, 3g (2-1-0), 3gd (5-2)",
                "2) Portugal 5p, 3g (1-2-0), 7gd (7-0)",
                "3) Cote d'Ivoire 4p, 3g (1-1-1), 1gd (4-3)",
                "4) Korea DPR 0p, 3g (0-0-3), -11gd (1-12)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test11()
        {
            string[] input = new string[] {
                "Pewee League",
                "One#2@2#Three",
                "Two#1@2#Three"
            };
            string[] expected = new string[] {
                "Pewee League",
                "1) Three 4p, 2g (1-1-0), 1gd (4-3)",
                "2) One 1p, 1g (0-1-0), 0gd (2-2)",
                "3) Two 0p, 1g (0-0-1), -1gd (1-2)" 
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test12()
        {
            string[] input = new string[] {
                "Pewee League",
                "One#1@0#Three",
                "Two#2@1#Three" 
            };
            string[] expected = new string[] {
                "Pewee League",
                "1) Two 3p, 1g (1-0-0), 1gd (2-1)",
                "2) One 3p, 1g (1-0-0), 1gd (1-0)",
                "3) Three 0p, 2g (0-0-2), -2gd (1-3)" 
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test13()
        {
            string[] input = new string[] {
                "Pewee League",
                "Two#0@1#Three",
                "Two#11@11#One",
                "One#31@31#Two",
                "Two#0@0#One" 
            };
            string[] expected = new string[] {
                "Pewee League",
                "1) Three 3p, 1g (1-0-0), 1gd (1-0)",
                "2) One 3p, 3g (0-3-0), 0gd (42-42)",
                "3) Two 3p, 4g (0-3-1), -1gd (42-43)" 
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
        [TestMethod]
        public void Test14()
        {
            string[] input = new string[] {
                "Liga BBVA",
                "Atletico Madrid#1@1#FC Barcelona Jr",
                "FC Barcelona#1@1#Atletico Madrid Jr"
            };
            string[] expected = new string[] {
                "Liga BBVA",
                "1) Atletico Madrid 1p, 1g (0-1-0), 0gd (1-1)",
                "2) Atletico Madrid Jr 1p, 1g (0-1-0), 0gd (1-1)",
                "3) FC Barcelona 1p, 1g (0-1-0), 0gd (1-1)",
                "4) FC Barcelona Jr 1p, 1g (0-1-0), 0gd (1-1)"
            };

            string[] actual = Program360.Soccer.getRankings(input);

            Assert.IsNotNull(actual, "Result is null");
            Assert.AreEqual(expected[0], actual[0], "Incorrect result");
            for (int i = 1; i < expected.Length; i++)
                if (i < actual.Length)
                    Assert.AreEqual(expected[i], actual[i], "Incorrect result");
                else
                    Assert.Fail("Result doesn't exist. Expected: \"" + expected[i] + "\"");
            Assert.AreEqual(expected.Length, actual.Length, "result has more values than expected");
        }
    }
}
