namespace RefactoringToPatterns.ComposeMethod {
    public class GeneralOperations {
        private readonly List list;

        public GeneralOperations(List list) {
            this.list = list;
        }

        public void DecideOperation(object element, int newSize) {
            CheckSize(newSize);

            AddSingleElement(element);
        }

        private void CheckSize(int newSize) {
            list.SpecificOperations.OperateWhenSizeIsGreaterThanLength(newSize, list);
        }

        private void AddSingleElement(object element) {
            list.elements[list.size++] = element;
        }

    }
}