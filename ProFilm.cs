using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextControler : MonoBehaviour
{
    public Text nameText;
    public Text infoText;
    public Text _ganr;


    public Image img;
    public Sprite[] imgs;

    public Text[] _names;
    public Text[] _infos;


    string[] names = new string[20];
    string[] info = new string[20];
    string[] ganr = new string[20];
    private void Start()
    {
        names[0] = "������-�����: ���� ����� ������";
        info[0] = "ϳ��� �������� ��� ̳����� ���������� ϳ���� ������� ������������ ����, �������� �� ������� ���� ����� �� ��� ������-������. � ������� ������ ���������� �� ���������� �� ��������� �� ������� �������� ��������, ������� ������ ��������, ���� �� � ����� ������� ���������� ���������� ��� ���� ������. ����� ���������� ����� ������ ��� �� �� ������, � ��������� ���� �� ����� ���������� ��������� � ������������, ����� �� �� ����� ���������� ������ ������-������ � �������������� ����, ��������� �������� ������ � ����������� ������� ���� ������.";

        names[1] = "�������� �������: ������";
        info[1] = "����������� ����� ���� � ����������� ����������, �������-���������� ������ ϳ� ̳����� �� ��������� �������, �� ����䳺 ����������� ������� ������� �������, ��� ����� ��������� ������������ �� ��������� ��� ��������. ������ ���� ������ ���� � �������� �������� ������ ��� ����������, ���� ���� ������������ �������������� ������ ���, ������� ̳������ ���� ����������� ��� ������ ���������� Top Gun, ���� �������� �������� ���������� ���. ����� � ������� �������� ������� � ��������� ����� �������, ��� ���� �������� ���������� �����.";

        names[2] = "������, ��� ����";
        info[2] = "�� ��� ����� ����� ���������� ������ �� ��������� ��������, ���� �� ����� ����� �������� ����������� �� ���� �������� � ������. ³� ��� � ������������ ����-����, �� ����� � ���� � ������, ��� ��������� � ������� ������� �����, ��� ��������� � ��������������� ����������. �� ��������� �'���������, ��� �����, � �� ����� �������������� ������ � ������ �����, �� ���������� ������ �� ���� � ������ ����������� �������.";

        names[3] = "������-������ � ���: �������� �����";
        info[3] = "��������� ����� ���� � ���� ��� ���� ������������, ��� ���������� ��� ������� � ��� ������-������ � ���. ����� � �������� ����� ������ ϳ��� � ������ ��� ���� ��'� ������� ��������� ���, �����䳺 � ������� ������ �������� � ��������� � �������, ��� ������ �� �� ��� ���������.";

        names[4] = "��������� / ����� 5: ���������";
        info[4] = "�� ������� XVIII ������� ������ �� ��'� ���� � ������� ������, �� ���� �� ϳ������� ������� �������, ��� �� ���� ��������� ������ ��������, ������ ������ ������ ���������, ��� ����� ����������� �����, �� �� ������� ���� �����. ��������� � ���������� � ��������������� �������, ���� ������� ��������� ������ ����, ��� ������� ���� ���� � ������������� ���� ��������������. �������� �����������, ������ ���� ���������� ��������� ��-��-�� � ����������� ������������ �������, �� ���������� �� ��������� ���� �� ������.";

        names[5] = "����� �����";
        info[5] = "ĳ� ������������ � 1884 ���� � ��������������. ����� � ���� ����� ������������� ��� ���������� ����� ����� ��������, �� �� ���� ������ �������. Ƴ��� �������� ���� ���� �������� ���� ���������, ��� ������� �� ��, ���� ���� ����� ���. ��������� � ��������� ������ ���������� �� ����� ���� ����� ������� � ���������, �� �������� ��������� �� � ��������. ��� �� ��������� ���� � ������, ����� ��� � ������ � ������� �����, ��� ��������� � ��������, ��� ������� ������ ��������� ���������� ����� ...";

        names[6] = "�������� �� �������� �������";
        info[6] = "����������� ����� ������ �� �������� ����������� ������ ���������� ����������� ����� ����.\r\nĳ� ���������� ������. ³������ ������������ ��������� ������ �����, ���� ����������� � �������, ��������� ������� ������ �������� �� ��������������. ��� ����� ������ ���� � ����������� ����������� \"�������� �������\" ����, ��� ������ ����� ��� � ������� ���� � ����. ����� �������, �� ������� ������ ������� ���� ��������� �������� �������� � ������ ����: � ����� ������ ���� ����� ������� ����� ����� ���������������, ������� � ����������� �������. �������������� �� ������� �����������, ���� ������������ ��������� �� ������ ��� ����� ���� ���������, ����� �� �����.\r\n����� ���� ��� �������� ������� ������� ����� ����������� ������� �����. � ������ ��� ����� ��������, �� ����� ���� ����� �������� ��������, � ����� ����� � �������� ��������� �� ������.";

        names[7] = "�� �����!";
        info[7] = "�� 1967 ��. ������������ ���������� ������� ������������� ���� � �'�����, ��� ����� �� ׳� �������, ���� ����� �� ����� ������������� �������� ��������� - �������� � ������� � ���������� ������� � ���, � �� ��������� �� ������� ��� ����������� �������� � ���� ������� ��. ������ ����, ��������� � ���������� ���, ׳� ������� ����������� ����: �� �� ���� ���� �� ��������� �������� � �������� � ���� ������� �������, ��� ��������� ���� ���� ������ ������, �� �'����� �� ��� ���. ���������� �������������, �������� � �������, �������� ����� ������� �� �'������, �� �� �����������, �� ���� ���������� �������� ���� ��������� ��.";

        names[8] = "����� ����� 2";
        info[8] = "������� ������ ������� ������ ���������� ���������, ��� ��������� � ���������� ���������� - ����� �������� �� ������ ������� ������, ��� ��� ����� ���� � ��������� ������, ������ ��� ������. �� ������ ��� �� �������� �����, �� ����� ���������� �� ������� ���� ������.";

        names[9] = "���: ����� � ���";
        info[9] = "��������� �������, ������ �����, ����� � ���������� ������ ������ � ����, ��� ��������� � �������������� ������. ³� �������� ������ ����������� ������ �� ����������� �� ������ ��� ������ ������������ ������ ����� - ���������� �������� ������������ ����� ����, ���� ������� �������� ��������, �� �������� ������� ����. ��� ������ �������, ��� ���������� ��������� �������� ���� ������� ������, ������������ ��������� ����� �... ���� ������� ������, ���������� ����� ������, ��� ������� ������ ��������.";

        names[10] = "������ �������: � ������������ ��������";
        info[10] = "������ ����� ������� ������������� �� ������� ��������� �� �������� ������ ������ ������, ������� ������������ ��� ������ ��������. ������� ��������� ����� ��� ��������� ������, ������� ������ � ������� � �������� �����, �������-�������, �� �������� �� ���������� ����, ��� ���� ������� ��������� ������ ������������ �� �������������. ����� � ���� � ������ ��������� ������� �� ���� ��������� ������, � ��� ����� ��������� ������� �������� ��������� ���������� ������, ���� ����� �� ��.";

        names[11] = "����� �������: ������� ��������";
        info[11] = "� ����������� ����� ��� ������� ������� ������, ���, �'����, ��� � ��� ������ ���� ̳���� ���������� ��������, ��� ��������� ��� ����� ���� ����� ������ �'����. ��� ����, �������� ������ ���������� ��������� ����� ����, �� ����� ���� ����������� ���������� �������.";

        names[12] = "������ �� ͳ�";
        info[12] = "ĳ� ������ ���������� �� ����� ��������� �������, �� ����� �� ͳ��, �� ����� �������� ����������� ������ ������ ����������. ��������� �������� ����쳺, �� �������� - �� ����� ��������������, ��� ���������� ��� ������������� �� �����, ��� ������ ������ ������, �� ������� �� ��������. ����� �������� ������������ ��� �����, ������, �������� �������� � ����� ���������� ��������.";


        ganr[0] = "г�: 2021\n" +
            "�����: ���\n" +
            "����: ����������";
        ganr[1] = "г�: 2022\n�����: ���\n����: �����";
        ganr[2] = "г�: 2022\n�����: ���\n����: �����";
        ganr[3] = "г�: 2022\n�����: ���\n����: ����������";
        ganr[4] = "г�: 2022\n�����: ���\n����: �������";
        ganr[5] = "г�: 2020\n�����: ��������������\n����: �������";
        ganr[6] = "г�: 2017\n�����: ��������������\n����: ��������";
        ganr[7] = "г�: 2022\n�����: ���\n����: �������";
        ganr[8] = "г�: 2022\n�����: ��������������\n����: �������";
        ganr[9] = "г�: 2022\n�����: ��������\n����: ����������";
        ganr[10] = "г�: 2022\n�����: ���\n����: ����������";
        ganr[11] = "г�: 2023\n�����: ���\n����: ����������";
        ganr[12] = "г�: 2022\n�����: ��������������\n����: ��������";

        for (int i = 0; i < names.Length; i++)
        {
            _names[i].text = names[i];
            _infos[i].text = ganr[i];
        }


    }


    public void On_Cliked(int i)
    {


        img.sprite = imgs[i];
        nameText.text = names[i];
        infoText.text = info[i];
        _ganr.text = ganr[i];
    }




}
