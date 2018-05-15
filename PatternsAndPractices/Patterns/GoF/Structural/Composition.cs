﻿using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PatternsAndPractices.Patterns.GoF.Structural
{
    public abstract class Component
    {
        protected readonly List<Component> _components = new List<Component>();

        public Component Parent { get; set; }
        public List<int> Values { get; set; }

        public void Add(Component c)
        {
            _components.Add(c);
            c.Parent = this;
        }

        public virtual void Update()
        {
            foreach (var c in _components)
                c.Update();
        }
    }

    public class RootComponent : Component
    {
        public RootComponent(List<int> values) => Values = values;

        public override void Update()
        {
            base.Update();
        }
    }

    public class AddComponent : Component
    {
        private readonly int _add;

        public AddComponent(int add) => _add = add;

        public override void Update()
        {
            Values = Parent.Values;
            Values = Values.Select(i => i + _add).ToList();

            base.Update();
        }
    }

    public class RemoveComponent : Component
    {
        public override void Update()
        {
            Values = Parent.Values;
            Values = Values.Where(i => (i % 2) != 0).ToList();

            base.Update();
        }
    }

    public class MultipleComponent : Component
    {
        private readonly int _modifier;

        public MultipleComponent(int modifier) => _modifier = modifier;

        public override void Update()
        {
            Values = Parent.Values;
            Values = Values.Select(i => i * _modifier).ToList();

            base.Update();
        }
    }

    public class ComponentTests
    {
        [Fact]
        public void Test()
        {
            var items = new List<int> { 1, 2, 3, 4 };

            var original = new RootComponent(items);
            var add = new AddComponent(2);
            var remove = new RemoveComponent();
            var multiply = new MultipleComponent(4);

            /*
             *        root
             *       /   \
             *    add(2) remove
             *      |
             *   multiply(4)
             */

            original.Add(add);
            original.Add(remove);
            add.Add(multiply);
            original.Update();
        }
    }
}