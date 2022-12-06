using System;
using System.Linq;
using System.Web;

namespace RefactoringToPatterns.ComposeMethod
{
    public class List
    {

        private readonly bool readOnly;
        private int size;
        private Object[] elements;

        public List(bool readOnly)
        {
            this.readOnly = readOnly;
            size = 0;
            elements = new Object[size];
        }

        public void Add(Object element) {
            IsReadOnly(element);
        }

        private void IsReadOnly(object element) {
            if (!readOnly) {
                int newSize = size + 1;

                CheckSize(newSize);

                elements[size++] = element;
            }
        }

        private void CheckSize(int newSize) {
            if (newSize > elements.Length) {
                Object[] newElements = new Object[elements.Length + 10];

                for (int i = 0; i < size; i++)
                    newElements[i] = elements[i];

                elements = newElements;
            }
        }

        public object[] Elements()
        {
            return elements;
        }

    }

}