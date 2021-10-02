// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetPartyTransactionSummaryTests
    {
        public static GetPartyTransactionSummaryController Fixture()
        {
            GetPartyTransactionSummaryController controller = new GetPartyTransactionSummaryController(new GetPartyTransactionSummaryRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetPartyTransactionSummaryController.Annotation());
            Assert.NotNull(actual);
        }
    }
}