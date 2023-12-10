using Store.Domain.Commands;

namespace Store.Tests.Commands
{
    [TestClass]
    public class CreateOrderCommandTests
    {
        [TestMethod]
        [TestCategory("Handlers")]
        public void Dado_um_novo_comando_invalido_o_pedido_nao_deve_ser_gerado()
        {
            var commmand = new CreateOrderCommand();
            commmand.Customer = "";
            commmand.ZipCode = "134110800";
            commmand.PromoCode = "123455678";
            commmand.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
            commmand.Items.Add(new CreateOrderItemCommand(Guid.NewGuid(), 1));
            commmand.Validate();

            Assert.AreEqual(commmand.Valid, false);
        }
    }
}
