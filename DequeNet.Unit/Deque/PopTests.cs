﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DequeNet.Unit.Deque
{
    public class PopTests
    {
        [Fact]
        public void PopLeft_ThrowsException_WhenEmpty()
        {
            var deque = new Deque<int>();
            Assert.Throws<InvalidOperationException>(() => deque.PopLeft());
        }

        [Fact]
        public void PopLeft_Returns_LeftmostItem()
        {
            var deque = new Deque<int>(new[] {1, 2, 3});
            var item = deque.PopLeft();

            Assert.Equal(1, item);
        }

        [Fact]
        public void PopLeft_DecreasesCount()
        {
            var deque = new Deque<int>(new[] { 1, 2, 3 });
            deque.PopLeft();

            Assert.Equal(2, deque.Count);
        }
    }
}
