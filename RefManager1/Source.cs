using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// �������� ������ - �����, ������ ��� ����� � ���������
    /// </summary>
    public class Source
    {
        /// <summary>
        /// �������� �����
        /// </summary>
        public Author MainAuthor { get; set; } = new Author();
        /// <summary>
        /// ��������� ������ (���� �������)
        /// </summary>
        public List<Author> Authors { get; set; } = new List<Author>() { };

        /// <summary>
        /// ��������� - �������� �������� 
        /// </summary>
        public string Title { get; set; } = String.Empty;
        /// <summary>
        /// ������������ (���� ����������)
        /// </summary>
        public string SubTitle { get; set; } = String.Empty;
        /// <summary>
        /// �������� ��������� (���� ����������)
        /// </summary>
        public string Description { get; set; } = String.Empty;
        /// <summary>
        /// ����������� (���� ���������)
        /// </summary>
        public string Comment { get; set; } = String.Empty;
        /// <summary>
        /// ����� � ���� ��������, ���� ���������
        /// </summary>
        public string URL { get; set; } = String.Empty;
        /// <summary>
        /// ����� ������������ �����, ���� ������� ��������� ����
        /// </summary>
        public string FullPathToFile { get; set; } = String.Empty;

        /// <summary>
        /// ���������� ��� �������������� ��������� ������ ������� - ��������
        /// </summary>
        private PropertyInfo[] _PropertyInfos = null;

        /// <summary>
        /// �����, ������������� ��� �������� � ���� ��� - ��������
        /// ����� ������� ����� � ���� ������
        /// </summary>
        /// <returns>������, �������������� �������� � �������� ������� ������</returns>
        public override string ToString()
        {
            /// ��������� ������ ���������� � �� �������� ����������
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties(); // �������� �������� ������

            /// ����� ��� ����������� ��������
            /// ����� �������, ��� ��������������� ������
            var sb = new StringBuilder();

            /// ��� ������� �������� � �������, ��������� �����
            foreach (var info in _PropertyInfos)
            {
                /// �������� �������� �������� ��� ��������, ��� ��� null
                /// ?? - �������� ������� � null
                /// ���� ����� ����� info.GetValue(this, null) �������� null
                /// �� � ��������� ������ ��, ��� ������ �� ??
                /// � ����� ������ ������ "(null)"
                /// ���� ����� �� �������, �� ����� ������ ����������, � ��� �������� ���������� ���������
                /// 
                var value = info.GetValue(this, null) ?? "(null)";
                /// �������� ������ � ����� ��� �������� - ��� ��������
                sb.AppendLine(info.Name + ": " + value.ToString());
            }

            /// ������� ��������� ����� � ���� ������
            return sb.ToString();
        }
    }
}