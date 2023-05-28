using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models.LogicalElements
{
    public abstract class TwoInputsGate : Gate
    {
        protected bool input1;
        protected bool input2;
        protected bool input3;
        protected bool isConnectedInput1;
        protected bool isConnectedInput2;
        protected bool isConnectedInput3;

        public TwoInputsGate()
        {
            Input1 = false;
            Input2 = false;
        }
        public bool Input1
        {
            get => input1;
            set => SetAndRaise(ref input1, value);
        }
        public bool Input2
        {
            get => input2;
            set => SetAndRaise(ref input2, value);
        }
        public bool Input3
        {
            get => input3;
            set => SetAndRaise(ref input3, value);
        }
        public bool IsConnectedInput1
        {
            get => isConnectedInput1;
            set => SetAndRaise(ref isConnectedInput1, value);

        }
        public bool IsConnectedInput2
        {
            get => isConnectedInput2;
            set => SetAndRaise(ref isConnectedInput2, value);

        }
        public bool IsConnectedInput3
        {
            get => isConnectedInput3;
            set => SetAndRaise(ref isConnectedInput3, value);

        }

    }
}
