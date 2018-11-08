using System;
using Xunit;

namespace CodeBasic.Tests
{
    public class UnitTest1
    {
        // Normal cases
        // Alternative cases
        // Exception cases

        [Fact]
        public void P2Win()
        {
            var Sut = new Pokdeng();
            Sut.PlayerBalance = 200;
            Sut.CheckGameResult(
                            10,
                            5, 1, 0, "", "", "",
                            5, 4, 0, "", "", ""
                            );
            Assert.Equal(210, Sut.PlayerBalance);
        }

        // [Fact]
        // public void P1Win()
        // {
        //     var Sut = new Pokdeng();
        // Sut.PlayerBalance = 200;
        //     var result = Sut.CheckGameResult(
        //                     10,
        //                     5, 3, 0, "", "", "",
        //                     5, 11, 0, "", "", ""
        //                     );
        // Assert.Equal(190, result);
        // }

        //         [Fact]
        // public void P1AsP2()
        // {
        //     var Sut = new Pokdeng();
        // Sut.PlayerBalance = 200;
        //     var Result = Sut.CheckGameResult(
        //                     10,
        //                     5, 3, 0, "", "", "",
        //                     5, 11, 1, "", "", ""
        //                     );
        // Assert.Equal(200, Result);
        // }
}
}
