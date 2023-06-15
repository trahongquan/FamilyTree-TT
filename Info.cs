using System.Windows.Forms;

namespace FamilyTree
{
    internal class Info : TreeNode
    {
        private Person personNode;
        private int gen;

        private TreeNode nodeTree;
        
        public Info() {
            this.personNode = new Person();
            this.personNode.Id = "";
            this.personNode.IdFather = "";
            this.personNode.NameNode = "";
            this.personNode.Date = "";
            this.personNode.PassDate = "";
            this.personNode.Sex = "";
            this.personNode.Home_place = "";
            this.personNode.Phone = "";
            this.personNode.Email = "";
            this.personNode.Position = "";
            this.personNode.Work_place = "";
            this.personNode.Note = "";
            this.nodeTree =  new TreeNode();
            this.nodeTree.Name = "";
            this.gen = 0;
        }
        public Info(Person personNode, TreeNode nodeTree, int gen)
        {
            this.personNode = personNode;
            this.nodeTree = nodeTree;
            this.gen = gen;
        }

        public TreeNode NodeTree { get => nodeTree; set => nodeTree = value; }
        public Person PersonNode { get => personNode; set => personNode = value; }
        public int Gen { get => gen; set => gen = value; }
    }
}
