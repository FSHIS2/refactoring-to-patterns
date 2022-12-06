using System;

namespace RefactoringToPatterns.ComposeMethod {
    public class SpecificOperations {
        private List list;

        public SpecificOperations(List list) {
            this.list = list;
        }
        public void OperateWhenSizeIsGreaterThanLength(int newSize, List list) {
            if (newSize > list.elements.Length) {
                Object[] newElements = new Object[list.elements.Length + 10];

                this.PerformOperationSteps(newElements);
            }
        }

        public void PerformOperationSteps(object[] newElements) {
            FindNewElements(newElements);

            AddNewElements(newElements);
        }

        private void FindNewElements(object[] newElements) {
            for (int i = 0; i < list.size; i++)
                newElements[i] = list.elements[i];
        }

        private void AddNewElements(object[] newElements) {
            list.elements = newElements;
        }

    }
}