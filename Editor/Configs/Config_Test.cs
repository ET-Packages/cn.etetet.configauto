using System;
using System.Collections.Generic;
public partial class Config_Test
{
    public object data = new
    {
        testobj = new { a = "1", b = 2 },
        //ֵΪ��ͨ����
        testint = new Dictionary<object, object>() { { 1, 2 }, { 2, 3 } },
        teststring = new Dictionary<object, object>() { { 1, "2" }, { 2, "3" } },
        //ֵΪ��ͨ��������
        testlist = new Dictionary<object, object[]>() { { 1, new object[] { 1, 2, 3 } } },
        //ֵΪ�Զ�����
        denglu = new Dictionary<object, object>() { { 1, new { a = "123" } }, { 2, new { b = "asdf" } }, { 3, new { c = "123", b = "111" } } },
        //ֵΪ�Զ���������
        testdenglulist = new Dictionary<object, object[]>() {
            { 1, new object[] { new { a = "123" }, new { b = "asdf" } } },
            { 2, new object[] { new { c = "123" }, new { b = "asdf" } } },
        },
    };
}
