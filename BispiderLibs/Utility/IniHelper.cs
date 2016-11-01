using System;

namespace V5_WinLibs.Utility {

    /// <summary>
    /// Ini�ļ�������
    /// </summary>
    public sealed class IniHelper {
        private static string _filePath = string.Empty;//�ļ�·��

        /// <summary>
        /// �ļ�·��
        /// </summary>
        public static string FilePath {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// Windows API ��INI�ļ�д����
        /// </summary>
        /// <param name="lpApplicationName">Ҫ������д�����ִ���С�����ơ�����ִ������ִ�Сд</param>
        /// <param name="lpKeyName">Ҫ���õ���������Ŀ��������ִ������ִ�Сд����null��ɾ�����С�ڵ�����������</param>
        /// <param name="lpString">ָ��Ϊ�����д����ִ�ֵ����null��ʾɾ����������е��ִ�</param>
        /// <param name="lpFileName">��ʼ���ļ������֡����û��ָ������·��������windows����windowsĿ¼�����ļ�������ļ�û���ҵ��������ᴴ����</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        /// <summary>
        /// Windows API ��INI�ļ�������
        /// </summary>
        /// <param name="lpApplicationName">�������в�����Ŀ��С�����ơ�����ִ������ִ�Сд������Ϊnull������lpReturnedString��������װ�����ini�ļ�����С�ڵ��б�</param>
        /// <param name="lpKeyName">����ȡ����������Ŀ��������ִ������ִ�Сд������Ϊnull������lpReturnedString��������װ��ָ��С����������б�</param>
        /// <param name="lpDefault">ָ������Ŀû���ҵ�ʱ���ص�Ĭ��ֵ������Ϊ�գ�""��</param>
        /// <param name="lpReturnedString">ָ��һ���ִ�����������������ΪnSize</param>
        /// <param name="nSize">ָ��װ�ص�lpReturnedString������������ַ�����</param>
        /// <param name="lpFileName">��ʼ���ļ������֡���û��ָ��һ������·������windows����WindowsĿ¼�в����ļ�</param>
        /// ע�⣺��lpKeyName����Ϊnull����ôlpReturnedString������������ָ��С�������������һ���б�
        /// ÿ�����һ��NULL�ַ��ָ������һ����������NULL�ַ���ֹ��Ҳ��ο�GetPrivateProfileInt������ע��
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);

        /// <summary>
        /// ��Ini�ļ���д��ֵ
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <param name="key">��������</param>
        /// <param name="value">����ֵ</param>
        /// <returns>ִ�гɹ�ΪTrue��ʧ��ΪFalse��</returns>
        public static long WriteIniKey(string section, string key, string value) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0 ||
                value.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, key, value, FilePath);
        }

        /// <summary>
        /// ɾ��ָ��С���еļ�
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <param name="key">��������</param>
        /// <returns>ִ�гɹ�ΪTrue��ʧ��ΪFalse��</returns>
        public static long DeleteIniKey(string section, string key) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, key, null, FilePath);
        }

        /// <summary>
        /// ɾ��ָ����С�ڣ��������С�������еļ���
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <returns>ִ�гɹ�ΪTrue��ʧ��ΪFalse��</returns>
        public static long DeleteIniSection(string section) {
            if (section.Trim().Length <= 0) return 0;

            return WritePrivateProfileString(section, null, null, FilePath);
        }

        /// <summary>
        /// ���ָ��С���м���ֵ
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <param name="key">��������</param>
        /// <param name="defaultValue">�����ֵΪ�գ���û�ҵ�������ָ����Ĭ��ֵ��</param>
        /// <param name="capacity">��������ʼ����С��</param>
        /// <returns>����ֵ</returns>
        public static string GetIniKeyValue(string section, string key, string defaultValue, int capacity) {
            if (section.Trim().Length <= 0 || key.Trim().Length <= 0) return defaultValue;

            System.Text.StringBuilder strTemp = new System.Text.StringBuilder(capacity);
            long returnValue = GetPrivateProfileString(section, key, defaultValue, strTemp, capacity, FilePath);

            return strTemp.ToString().Trim();
        }

        /// <summary>
        /// ���ָ��С���м���ֵ
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <param name="key">��������</param>
        /// <param name="defaultValue">�����ֵΪ�գ���û�ҵ�������ָ����Ĭ��ֵ��</param>
        /// <returns>����ֵ</returns>
        public static string GetIniKeyValue(string section, string key, string defaultValue) {
            return GetIniKeyValue(section, key, defaultValue, 1024);
        }

        /// <summary>
        /// ���ָ��С���м���ֵ
        /// </summary>
        /// <param name="section">С�ڵ�����</param>
        /// <param name="key">��������</param>
        /// <returns>����ֵ</returns>
        public static string GetIniKeyValue(string section, string key) {
            return GetIniKeyValue(section, key, string.Empty, 1024);
        }
    }
}