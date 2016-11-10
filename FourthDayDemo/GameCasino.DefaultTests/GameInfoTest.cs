namespace GameCasino.DefaultTests
{
    using Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class GameInfoTest
    {
        [Test]
        public void ConnectPlayerShouldAddOnePlayer()
        {
            GameInfo gameInfo = new GameInfo();
            gameInfo.ConnectPlayer("Pesho");

            Assert.AreEqual(1, gameInfo.PlayersPlaying);
        }

        [Test]
        public void Connect100PlayerShouldAdd100Player()
        {
            GameInfo gameInfo = new GameInfo();
            for (int i = 0; i < 100; i++)
            {
                gameInfo.ConnectPlayer("Pesho");
            }

            Assert.AreEqual(100, gameInfo.PlayersPlaying);
        }

        [Test]
        public void IdShouldNotBeNull()
        {
            GameInfo info = new GameInfo();

            Assert.AreNotEqual(info.Id, Guid.Empty);
        }
    }
}
