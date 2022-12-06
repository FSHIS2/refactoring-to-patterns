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

        public SpecificOperations SpecificOperations {
            get { return specificOperations; }
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

        public object[] Elements()
        {
            return elements;
        }

    }

}