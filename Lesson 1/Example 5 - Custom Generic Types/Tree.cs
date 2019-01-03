using System;
using System.Collections.Generic;

namespace Example_5 
{
    class Tree<T> where T : IComparable<T>
    {
        internal TreeNode<T> head;
        public Tree() { }

        public int Depth
        {
            get { return head.Depth; }
        }
        public void Add(T item)
        {
            if (head != null)
            {
                head.Add(item);
            }
            else
            {
                head = new TreeNode<T>(item);
            }
        }

        public IEnumerable<T> Traverse()
        {
            return head.Traverse();
        }

        public T Remove(T item)
        {
            TreeNode<T> current = head;
            TreeNode<T> parent = head;
            bool isLeftChild = true;
            while (item.CompareTo(current.Value) != 0)
            {
                parent = current;
                if (item.CompareTo(current.Value) < 0)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
            }
            if (current == null)
            {
                throw new InvalidOperationException("Cannot remove from tree, item not found.");
            }
            if ((current.Left == null) && (current.Right == null))
            {
                if (current == head)
                {
                    head = null;
                }
                else if (isLeftChild)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == head)
                {
                    head = current.Left;
                }
                else if (isLeftChild)
                {
                    parent.Left = current.Left;
                }
                else
                {
                    parent.Right = current.Left;
                }
            }
            else if (current.Left == null)
            {
                if (current == head)
                {
                    head = current.Right;
                }
                else if (isLeftChild)
                {
                    parent.Left = current.Right;
                }
                else
                {
                    parent.Right = current.Right;
                }
            }
            else
            {
                TreeNode<T> t = current.Right;
                TreeNode<T> r = null;
                while (t.Left != null)
                {
                    r = t;
                    t = t.Left;
                }
                if (r == null)
                {
                    current.Right.Left = current.Left;
                    if (isLeftChild)
                    {
                        parent.Left = current.Right;
                    }
                    else
                    {
                        parent.Right = current.Right;
                    }
                }
                else
                {
                    t.Left = current.Left;
                    r.Left = t.Right;
                    t.Right = current.Right;
                    if (isLeftChild)
                    {
                        parent.Left = t;
                    }
                    else
                    {
                        parent.Right = t;
                    }
                }
            }
            return item;
        }

        private TreeNode<T> Find(T item, TreeNode<T> node)
        {
            if (node.Value.CompareTo(item) == 0)
            {
                return node;
            }
            else
            {
                if (item.CompareTo(node.Value) < 0 && node.Left != null)
                {
                    return Find(item, node.Left);
                }
                else if (item.CompareTo(node.Value) >= 0 && node.Right != null)
                {
                    return Find(item, node.Right);
                }
                else
                {
                    return null;
                }
            }
        }

        internal class TreeNode<U> where U : IComparable<U>
        {
            public TreeNode(U value)
            {
                Value = value;
            }
            public U Value { get; set; }
            public TreeNode<U> Left { get; set; }
            public TreeNode<U> Right { get; set; }

            public void Add(U item)
            {
                if (item.CompareTo(Value) < 0)
                {
                    if (Left == null)
                    {
                        Left = new TreeNode<U>(item);
                    }
                    else
                    {
                        Left.Add(item);
                    }
                }
                else
                {
                    if (Right == null)
                    {
                        Right = new TreeNode<U>(item);
                    }
                    else
                    {
                        Right.Add(item);
                    }
                }
            }

            public IEnumerable<U> Traverse()
            {
                if (Left != null) foreach (U item in Left.Traverse()) yield return item;
                yield return Value;
                if (Right != null) foreach (U item in Right.Traverse()) yield return item;
            }

            public int Depth
            {
                get
                {
                    return ((Left?.Depth ?? 0) > (Right?.Depth ?? 0) ? Left?.Depth ?? 0 : Right?.Depth ?? 0) + 1;
                }
            }
        }
    }
    }