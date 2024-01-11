﻿using NUnit.Framework;
using SchOopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void TestSubjectId()
        {
            Subject subject = new Subject();
            subject.SubjectId = 3;
            int subjectId = subject.SubjectId;
            Assert.AreEqual(3, subjectId);
        }
        [Test]
        public void TestSubjectName()
        {
            Subject subject = new Subject();
            subject.SubjectName = "English";
            string subjectName = subject.SubjectName;
            Assert.AreEqual("English", subjectName);
        }
    }
}

