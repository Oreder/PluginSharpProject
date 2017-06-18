using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree.Command
{
    class StackCommand
    {
        private List<Command> stack;
        private int position;
        
        public StackCommand()
        {
            stack = new List<Command>();
            position = -1;
        }
        
        /// <summary>
        /// Load command
        /// </summary>
        /// <param name="list"></param>
        public void Load(List<Group> list)
        {
            LoadCreator creator = new LoadCreator(list);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Insert group command
        /// </summary>
        /// <param name="group"></param>
        public void InsertGroup(Group group)
        {
            InsertGroupCreator creator = new InsertGroupCreator(group);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Insert student command
        /// </summary>
        /// <param name="student"></param>
        public void InsertStudent(Student student)
        {
            InsertStudentCreator creator = new InsertStudentCreator(student);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Delete group command
        /// </summary>
        /// <param name="group"></param>
        public void DeleteGroup(Group group)
        {
            DeleteGroupCreator creator = new DeleteGroupCreator(group);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Delete student command
        /// </summary>
        /// <param name="student"></param>
        public void DeleteStudent(Student student)
        {
            DeleteStudentCreator creator = new DeleteStudentCreator(student);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Rename group command
        /// </summary>
        /// <param name="old_name"></param>
        /// <param name="new_name"></param>
        public void RenameGroup(string old_name, string new_name)
        {
            RenameGroupCreator creator = new RenameGroupCreator(old_name, new_name);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Update student command
        /// </summary>
        /// <param name="old_rec"></param>
        /// <param name="new_rec"></param>
        public void UpdateStudent(Student old_rec, Student new_rec)
        {
            UpdateStudentCreator creator = new UpdateStudentCreator(old_rec, new_rec);
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Clear command
        /// </summary>
        public void Clear()
        {
            ClearCreator creator = new ClearCreator();
            DoCommand(creator.FactoryMethod());
        }

        /// <summary>
        /// Execute command
        /// </summary>
        /// <param name="command"></param>
        public void DoCommand(Command command)
        {
            command.Do();
            stack.RemoveRange(++position, stack.Count - position);
            stack.Add(command);
        }

        /// <summary>
        /// Undo command
        /// </summary>
        public void Undo()
        {
            if (position >= 0)
                stack[position--].Undo();
        }

        /// <summary>
        /// Redo command
        /// </summary>
        public void Redo()
        {
            if (position < stack.Count - 1)
                stack[++position].Do();
        }

        /// <summary>
        /// Clear commands' history
        /// </summary>
        public void ClearStackCommand()
        {
            stack.Clear();
        }
    }
}
