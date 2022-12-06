namespace RefactoringToPatterns.ComposeMethod {
    public class GeneralOperations {
        private List list;

        public GeneralOperations(List list) {
            this.list = list;
        }

        public void DecideOperation(object element, int newSize) {
            CheckSize(newSize);

            AddSingleElement(element);
        }

        private void AddSingleElement(object element) {
            list.elements[list.size++] = element;
        }

        private void CheckSize(int newSize) {
            list.OperateWhenSizeIsGreaterThanLength(newSize);
        }
    }
}