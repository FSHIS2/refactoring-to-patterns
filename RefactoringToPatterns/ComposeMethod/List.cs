using System;
using System.Linq;
using System.Web;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List
    {

        private readonly bool readOnly;
        public int size;
        public Object[] elements;
        private readonly SpecificOperations specificOperations;
        private readonly GeneralOperations generalOperations;

        public List(bool readOnly)
        {
            this.readOnly = readOnly;
            size = 0;
            elements = new Object[size];
            specificOperations = new SpecificOperations(this);
            generalOperations = new GeneralOperations(this);
        }

        public void Add(Object element) {
            IsReadOnly(element);
        }

        private void IsReadOnly(object element) {
            if (!readOnly) {
                int newSize = size + 1;

                generalOperations.DecideOperation(element, newSize);
            }
        }

        public void OperateWhenSizeIsGreaterThanLength(int newSize) {
            if (newSize > elements.Length) {
                Object[] newElements = new Object[elements.Length + 10];

                specificOperations.OperateWithMoreThanOneElement(newElements);
            }
        }

        public object[] Elements()
        {
            return elements;
        }

    }

}