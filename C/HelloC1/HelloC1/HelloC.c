#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
// stdio.h = ����� �Լ� �����ϴ� ���̺귯��
int main()
{
    // ���α׷� ���� �� ������ ��ɾ� main���� �ۼ�
    // ����� : printf()���, scanf()�Է�

    int num;
    char ch; // C���� String�� ����
    double d;
    // int > char > double ������ �Է¹ޱ�
    // %d > %c > %lf


    scanf("%d %c %lf", &num, &ch, &d);
    // $c : ������ �Է¹��� �� �ִ�.
    printf("CCCC \n");
    printf("������ : %d \n", num);
    printf("������ : %c \n", ch);
    printf("�Ǽ��� : %.1f \n", d); // double�� ��½� %f ����ص� ����
    // %.1f > �Ҽ��� ���ڸ� ����
    printf("�ȳ��ϼ��� \n");

}