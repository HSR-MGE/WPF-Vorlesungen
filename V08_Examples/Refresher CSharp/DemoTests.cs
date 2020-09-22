// ReSharper disable StringLiteralTypo
// ReSharper disable ConvertToLocalFunction
// ReSharper disable ConvertToLambdaExpression
// ReSharper disable CommentTypo

namespace Refresher_CSharp
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void Properties()
        {
            var person = new Person
            {
                FirstName = "Thomas",
                LastName = "Kälin"
            };

            person.FirstName.Should().Be("Thomas");
            person.LastName.Should().Be("Kälin");
            person.FullName.Should().Be("Kälin Thomas");
            person.FullNameInv.Should().Be("Thomas Kälin");
        }

        [Test]
        public void Delegates()
        {
            const int x = 2;
            const int y = 3;

            var calculator = new Calculator();
            calculator.Add(x, y).Should().Be(5);
            calculator.Multiply(x, y).Should().Be(6);

            Calculator.Calculation add = calculator.Add;
            Calculator.Calculation subtract1 = delegate(int a, int b) { return a - b; };
            Calculator.Calculation subtract2 = (a, b) => a - b;

            add(x, y).Should().Be(5);
            subtract1(x, y).Should().Be(-1);
            subtract2(x, y).Should().Be(-1);
        }

        [Test]
        public void Action_And_Func_And_Lambdas()
        {
            var calculator = new Calculator();

            Func<int, int, int> add = calculator.Add;
            Func<int, int, int> subtract1 = delegate (int a, int b) { return a - b; };
            Func<int, int, int> subtract2 = (a, b) => a - b;

            Action<int, int> addAndSubtract = (a, b) =>
            {
                // Closure: Zugriff auf add, subtract1 und subtract2 möglich
                add(a, b).Should().Be(a + b);
                subtract1(a, b).Should().Be(a - b);
                subtract2(a, b).Should().Be(a - b);
            };

            addAndSubtract(2, 3);
        }

        [Test]
        public void Events()
        {
            var person = new Person();

            EventHandler<string> onNickNameChanged = (sender, name) =>
            {
                Console.WriteLine(name);
            };

            person.NickNameChanged += onNickNameChanged;
            person.NickNameChanged += onNickNameChanged;
            person.NickName = "N00b";

            person.NickNameChanged -= onNickNameChanged;
            person.NickName = "Advanc3d";

            person.NickNameChanged -= onNickNameChanged;
            person.NickName = "Pr0";
        }
    }
}