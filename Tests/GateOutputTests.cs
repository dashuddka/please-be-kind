using CourseWork.Models.LogicalElements;

namespace Tests
{
    public class GateOutputTests
    {
        [Fact]
        public void NotGateOutputTestTrueInput()
        {
            NotGate gate = new NotGate() { Input = true, IsConnected = true };
            Assert.False(gate.Output());
        }
        [Fact]
        public void NotGateOutputTestFalseInput()
        {
            NotGate gate = new NotGate() { Input = false, IsConnected = true };
            Assert.True(gate.Output());
        }
        [Fact]
        public void NotGateOutputTestFalseInputNotConnected()
        {
            NotGate gate = new NotGate() { Input = false, IsConnected = false };
            Assert.False(gate.Output());
        }
        [Fact]
        public void AndGateOutputTestFalseAndFalseInput()
        {
            AndGate gate = new AndGate() { Input1 = false, Input2 = false };
            Assert.False(gate.Output());
        }
        [Fact]
        public void AndGateOutputTestTrueAndFalseInput()
        {
            AndGate gate = new AndGate() { Input1 = true, Input2 = false };
            Assert.False(gate.Output());
        }
        [Fact]
        public void AndGateOutputTestTrueAndTrueInput()
        {
            AndGate gate = new AndGate() { Input1 = true, Input2 = true };
            Assert.True(gate.Output());
        }
        [Fact]
        public void OrGateOutputTestFalseAndFalseInput()
        {
            OrGate gate = new OrGate() { Input1 = false, Input2 = false };
            Assert.False(gate.Output());
        }
        [Fact]
        public void OrGateOutputTestTrueAndFalseInput()
        {
            OrGate gate = new OrGate() { Input1 = true, Input2 = false };
            Assert.True(gate.Output());
        }
        [Fact]
        public void OrGateOutputTestTrueAndTrueInput()
        {
            OrGate gate = new OrGate() { Input1 = true, Input2 = true };
            Assert.True(gate.Output());
        }
        [Fact]
        public void XorGateOutputTestFalseAndFalseInput()
        {
            XorGate gate = new XorGate() { Input1 = false, Input2 = false };
            Assert.False(gate.Output());
        }
        [Fact]
        public void XorGateOutputTestTrueAndFalseInput()
        {
            XorGate gate = new XorGate() { Input1 = true, Input2 = false };
            Assert.True(gate.Output());
        }
        [Fact]
        public void XorGateOutputTestTrueAndTrueInput()
        {
            XorGate gate = new XorGate() { Input1 = true, Input2 = true };
            Assert.False(gate.Output());
        }
        [Fact]
        public void EncoderGateOutputTestFalseAndFalseInput()
        {
            EncoderGate gate = new EncoderGate() { Input1 = false, Input2 = false, Input3 = false };
            Assert.False(gate.Output());
            Assert.False(gate.Output2());
        }
        [Fact]
        public void EncoderGateOutputTestTrueAndFalseInput()
        {
            EncoderGate gate = new EncoderGate() { Input1 = true, Input2 = false, Input3 = false };
            Assert.True(gate.Output2());
            Assert.True(gate.Output());
        }
        [Fact]
        public void EncoderGateOutputTestFalseAndTrueInput()
        {
            EncoderGate gate = new EncoderGate() { Input1 = false, Input2 = true, Input3 = false };
            Assert.True(gate.Output());
            Assert.False(gate.Output2());
        }
        [Fact]
        public void EncoderGateOutputTestTrueAndTrueInput()
        {
            EncoderGate gate = new EncoderGate() { Input1 = false, Input2 = false, Input3 = true };
            Assert.True(gate.Output2());
            Assert.False(gate.Output());
        }

    }
}