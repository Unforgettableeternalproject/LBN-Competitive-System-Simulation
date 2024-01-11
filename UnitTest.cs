using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using LBN_Competitive_System_Simulation.Forms;
using static System.Net.Mime.MediaTypeNames;
using LBN_Competitive_System_Simulation.Forms.Subforms;
using System.Threading;
using Newtonsoft.Json;
using System.IO;

namespace LBN_Competitive_System_Simulation
{
    [TestClass]
    public class ConstructorTest
    {

        [TestMethod]
        public void TestIDConstructor()
        {
            // Arrange
            ID user = new ID("Bernie", "123456", "ptyc4076@gmail.com", "Admin", "bcd2611f-a230-41e6-bd31-f4eac0d98cb5");

            // Act & Assert
            Assert.AreEqual("Bernie", user.Username);
            Assert.AreEqual("123456", user.Password);
            Assert.AreEqual("ptyc4076@gmail.com", user.Email);
            Assert.AreEqual("Admin", user.Role);
            Assert.AreEqual("bcd2611f-a230-41e6-bd31-f4eac0d98cb5", user.UUID);
        }
        [TestMethod]
        public void TestLeagueConstructor()
        {
            var testID = new ID("Berniee", "122334", "ptyc4076@gmail.com", "League Owner", "bcd2611f-a230-41e6-bd31-f4eac0d98cb5");
            var testMembers = new List<ID>() { testID };

            League league = new League("小人物聯盟", testID, "休閒型聯盟", "人小志氣高，明天會更好", testMembers);

            Assert.AreEqual("小人物聯盟", league.Name);
            Assert.AreEqual(testID, league.Owner);
            Assert.AreEqual("休閒型聯盟", league.LeagueType);
            Assert.AreEqual("人小志氣高，明天會更好", league.Motto);
            Assert.AreEqual(testMembers, league.Members);
        }
        [TestMethod]
        public void TestProposalConstructor()
        {
            var date = DateTime.Now;
            Proposal testProposal = new Proposal("測試聯盟", date, "聯盟賽", "單一淘汰賽制", 15);

            Assert.AreEqual(testProposal.LeagueName, "測試聯盟");
            Assert.AreEqual(testProposal.Date, date);
            Assert.AreEqual(testProposal.GameType, "聯盟賽");
            Assert.AreEqual(testProposal.GameFormat, "單一淘汰賽制");
            Assert.AreEqual(testProposal.DurationDays, 15);
        }
    }

    [TestClass]
    public class UserTest
    {
        public static readonly List<ID> testcase = new List<ID>()
        {
            new ID("Bernie", "123456", "ptyc4076@gmail.com", "Normal", "4f020cd8-3110-4f20-af6c-68b5d7412dd8"),
            new ID("Bernie", "123456", "ptyc4076@gmail.com", "Admin", "bcd2611f-a230-41e6-bd31-f4eac0d98cb5"),
            new ID("Einreb", "654321", "6704cytp@gmail.com", "Player", "h897c6b4-aa21-4t4f-b54h-fb34c5610f35"),
            new ID("GoodLord", "Lmao", "Nord@gmail.com", "League Owner","b9f8c6a2-ae16-4a7f-b53b-fbbbcd610f35" )
        };
        public static readonly League testLeague = new League("小人物聯盟", testcase[3], "休閒型聯盟", "人小志氣高，明天會更好!", new List<ID>() { testcase[3], new ID("HX閃電狼", "Wolfy", "LightningWolf@gmail.com", "Player", "c7g7c6b4-aa21-4t4f-b54h-fb34c5610f35") });
        [TestClass]
        public class AudienceTest
        {
            static BrowseForm testAudience;

            [TestMethod]
            public void CanWatchStream()
            {
                testAudience = new BrowseForm(testcase[0]);
                try
                {
                    testAudience.Show();
                    testAudience.CanWatchStream();
                }
                catch
                {
                    Assert.Fail();
                }
            }
        }
        [TestClass]
        public class AdvertiserTest
        {
            static AdvertisementForm testAdvertiser;

            [TestMethod]
            public void CanDeployAds()
            {
                testAdvertiser = new AdvertisementForm(testcase[0], null);
                try
                {
                    testAdvertiser.Show();
                    testAdvertiser.CanDeployAds();
                }
                catch
                {
                    Assert.Fail();
                }
            }
        }
        [TestClass]
        public class AdministratorTest
        {
            AdminMainForm testAdmin;

            [TestMethod]
            public void ArrangeNewGame()
            {
                testAdmin = new AdminMainForm(testcase[1]);
                try
                {
                    testAdmin.Show();
                    testAdmin.AddEvent();
                }
                catch
                {
                    Assert.Fail();
                }
            }

            [TestMethod]
            public void ManageUsers()
            {
                var originalUsers = JsonConvert.DeserializeObject<List<ID>>
                    (File.ReadAllText(@"..\..\ExampleJSONs\NormalUserID.json"));
                testAdmin = new AdminMainForm(testcase[1]);
                try
                {
                    testAdmin.Show();
                    testAdmin.ManageUser();
                }
                catch
                {
                    Assert.Fail();
                }
                finally
                {
                    string userJson = JsonConvert.SerializeObject(originalUsers, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleJSONs\NormalUserID.json", userJson);
                }
            }
        }
        [TestClass]
        public class PlayerTest
        {
            PlayerMainForm testPlayer;

            [TestMethod]
            public void JoinGame()
            {
                testPlayer = new PlayerMainForm(testcase[3]);
                try
                {
                    testPlayer.Show();
                    testPlayer.JoinGame();
                }
                catch
                {
                    Assert.Fail();
                }
            }

            [TestMethod]
            public void JoinLeague()
            {
                var originalLeague = JsonConvert.DeserializeObject<List<League>>
                    (File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
                var originalUsers = JsonConvert.DeserializeObject<List<ID>>
                    (File.ReadAllText(@"..\..\ExampleJSONs\SpecialUserID.json"));
                testPlayer = new PlayerMainForm(testcase[2]);
                try
                {
                    testPlayer.Show();
                    testPlayer.JoinLeague();
                }
                catch
                {
                    Assert.Fail();
                }
                finally
                {
                    string leagueJson = JsonConvert.SerializeObject(originalLeague, Formatting.Indented);
                    string userJson = JsonConvert.SerializeObject(originalUsers, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleJSONs\Leagues.json", leagueJson);
                    File.WriteAllText(@"..\..\ExampleJSONs\SpecialUserID.json", userJson);
                }
            }
        }
        [TestClass]
        public class LeagueOwnerTest
        {
            PlayerMainForm testPlayer;
            LeagueMainForm testLO;

            [TestMethod]
            public void ProposeGame()
            {
                testLO = new LeagueMainForm(testcase[3], null, testLeague);
                try
                {
                    testLO.Show();
                    testLO.ProposeGame();
                }
                catch
                {
                    Assert.Fail();
                }
            }

            [TestMethod]
            public void AnnounceWinner()
            {
                testLO = new LeagueMainForm(testcase[3], null, testLeague);
                try
                {
                    testLO.Show();
                    testLO.AnnounceWinner();
                }
                catch
                {
                    Assert.Fail();
                }
            }
            [TestMethod]
            public void CreateLeague()
            {
                var originalLeague = JsonConvert.DeserializeObject<List<League>>
                    (File.ReadAllText(@"..\..\ExampleJSONs\Leagues.json"));
                var originalUsers = JsonConvert.DeserializeObject<List<ID>>
                    (File.ReadAllText(@"..\..\ExampleJSONs\SpecialUserID.json"));
                testPlayer = new PlayerMainForm(testcase[2]);
                try
                {
                    testPlayer.Show();
                    testPlayer.CreateLeague();
                }
                catch
                {
                    Assert.Fail();
                }
                finally
                {
                    string leagueJson = JsonConvert.SerializeObject(originalLeague, Formatting.Indented);
                    string userJson = JsonConvert.SerializeObject(originalUsers, Formatting.Indented);
                    File.WriteAllText(@"..\..\ExampleJSONs\Leagues.json", leagueJson);
                    File.WriteAllText(@"..\..\ExampleJSONs\SpecialUserID.json", userJson);
                }
            }
        }
    }
}
