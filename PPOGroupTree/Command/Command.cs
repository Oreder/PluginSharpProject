using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree.Command
{
    class Command
    {
        private GroupStructure tree;

        public Command()
        {
            tree = GroupStructure.Instance;
        }
        
        public virtual void Do() { }
        public virtual void Undo() { }
        public GroupStructure Tree { get { return tree; } }
    }

    class LoadCommand : Command
    {
        private List<Group> new_list;
        private List<Group> old_list;
        
        public LoadCommand(List<Group> list) : base()
        {
            this.new_list = list;
            this.old_list = base.Tree.Groups;
        }
        
        public override void Do()
        {
            base.Tree.LoadGroupStructure(new List<Group>(new_list));
        }

        public override void Undo()
        {
            Tree.LoadGroupStructure(new List<Group>(old_list));
        }
    }

    class InsertGroupCommand : Command
    {
        private Group group;
        
        public InsertGroupCommand(Group group) : base()
        {
            this.group = new Group(group);
        }
        
        public override void Do()
        {
            base.Tree.InsertGroup(group);
        }
        public override void Undo()
        {
            base.Tree.DeleteGroup(group);
        }
    }

    class InsertStudentCommand : Command
    {
        private Student student;

        public InsertStudentCommand(Student student) : base()
        {
            this.student = student;
        }
        
        public override void Do()
        {
            base.Tree.InsertStudent(student);
        }

        public override void Undo()
        {
            base.Tree.DeleteStudent(student);
        }
    }

    class DeleteGroupCommand : Command
    {
        private Group group;
        
        public DeleteGroupCommand(Group group) : base()
        {
            this.group = new Group(group);
        }

        public override void Do()
        {
            base.Tree.DeleteGroup(group);
        }

        public override void Undo()
        {
            base.Tree.InsertGroup(group);
        }
    }

    class DeleteStudentCommand : Command
    {
        private Student student;
        
        public DeleteStudentCommand(Student student) : base()
        {
            this.student = student;
        }

        public override void Do()
        {
            base.Tree.DeleteStudent(student);
        }
        
        public override void Undo()
        {
            base.Tree.InsertStudent(student);
        }
    }

    class RenameGroupCommand : Command
    {
        private string old_name;
        private string new_name;
        
        public RenameGroupCommand(string old_name, string new_name) : base()
        {
            this.old_name = old_name;
            this.new_name = new_name;
        }
        
        public override void Do()
        {
            base.Tree.RenameGroup(old_name, new_name);
        }
        
        public override void Undo()
        {
            base.Tree.RenameGroup(new_name, old_name);
        }
    }

    class UpdateStudentCommand : Command
    {
        private Student old_std;
        private Student new_std;
        
        public UpdateStudentCommand(Student old_std, Student new_std) : base()
        {
            this.old_std = old_std;
            this.new_std = new_std;
        }
        public override void Do()
        {
            base.Tree.UpdateStudent(old_std, new_std);
        }
        public override void Undo()
        {
            base.Tree.UpdateStudent(new_std, old_std);
        }
    }

    class ClearCommand : Command
    {
        private List<Group> groups;
        
        public ClearCommand() : base()
        {
            groups = new List<Group>(base.Tree.Groups);
        }
        
        public override void Do()
        {
            base.Tree.ClearAll();
        }
        
        public override void Undo()
        {
            base.Tree.LoadGroupStructure(groups);
        }
    }

    ///------------------------------------------------------
    /// <summary>
    /// Using factory methods to request commands
    /// </summary>
    /// -----------------------------------------------------
    
    class Creator
    {
        public virtual Command FactoryMethod() { return new Command(); }
    }

    class LoadCreator : Creator
    {
        private List<Group> list;
        
        public LoadCreator(List<Group> list)
        {
            this.list = list;
        }
        
        public override Command FactoryMethod()
        {
            return new LoadCommand(list);
        }
    }

    class InsertGroupCreator : Creator
    {
        private Group group;
        
        public InsertGroupCreator(Group group)
        {
            this.group = group;
        }
        
        public override Command FactoryMethod()
        {
            return new InsertGroupCommand(group);
        }
    }

    class InsertStudentCreator : Creator
    {
        private Student student;

        public InsertStudentCreator(Student student)
        {
            this.student = student;
        }
        
        public override Command FactoryMethod()
        {
            return new InsertStudentCommand(student);
        }
    }

    class DeleteGroupCreator : Creator
    {
        private Group group;
        
        public DeleteGroupCreator(Group group)
        {
            this.group = group;
        }
        
        public override Command FactoryMethod()
        {
            return new DeleteGroupCommand(group);
        }
    }

    class DeleteStudentCreator : Creator
    {
        private Student student;
        
        public DeleteStudentCreator(Student student)
        {
            this.student = student;
        }
        
        public override Command FactoryMethod()
        {
            return new DeleteStudentCommand(student);
        }
    }

    class RenameGroupCreator : Creator
    {
        private string old_name;
        private string new_name;
        
        public RenameGroupCreator(string old_name, string new_name)
        {
            this.old_name = old_name;
            this.new_name = new_name;
        }

        public override Command FactoryMethod()
        {
            return new RenameGroupCommand(old_name, new_name);
        }
    }

    class UpdateStudentCreator : Creator
    {
        private Student old_std;
        private Student new_std;
        
        public UpdateStudentCreator(Student old_std, Student new_std)
        {
            this.old_std = old_std;
            this.new_std = new_std;
        }
        
        public override Command FactoryMethod()
        {
            return new UpdateStudentCommand(old_std, new_std);
        }
    }

    class ClearCreator : Creator
    {
        public override Command FactoryMethod()
        {
            return new ClearCommand();
        }
    }
}
