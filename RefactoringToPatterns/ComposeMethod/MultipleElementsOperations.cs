namespace RefactoringToPatterns.ComposeMethod {
    public class MultipleElementsOperations {
        private List list;

        public MultipleElementsOperations(List list) {
            this.list = list;
        }

        public void OperateWithElements(object[] newElements) {
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