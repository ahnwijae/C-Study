#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int main() {
	// ������ : ����Ű�� ��
	// &(�ּҿ�����), *(����Ų �����)

	int num = 5;
	printf("�� : %d \n", num);
	printf("%d\n\n\n", &num); // &�ּҿ����ڷ� ���� num�� �޸𸮿� ����� �ּҸ� ���
	
	// ������ ���� : "Ư�� �޸𸮸� ����Ű�� ����"
	// num�� ����Ű�� ���� ����
	int* pnum; // ������ ���� ����, "��� ������ ����Ű�� pnum ����"
	pnum = &num;
	printf("pnum �� : %d \n", pnum);
	printf("*pnum �� : %d \n\n\n", *pnum);


	// ���� : 5���� ������ �Է¹ް� �������鿡 ���� �ѹ��� ��ȸ�ϸ�
	// 60�Ʒ��� ���� �߰ߵǸ� 60���� ���� �����Ѵ�.
	// �� �ڷ� 5���� ������ ���� ��հ��� ���ض�.
	// �ٸ� �迭�� ����ϵ� ������������ �迭�� ����ϰ�
	// int* pscore[5];
	// [] ��ȣ�� ������ �迭�� ������ ���� ����Ѵ�.
	// (�迭�� ��ȸ���� �ٸ� ����� ã�ƺ� ��)
	
	
	int score0;
	int score1;
	int score2;
	int score3;
	int score4;
	int avg = 0;
	scanf("%d %d %d %d %d", &score0, &score1, &score2, &score3, &score4);
	int* score[] = { &score0, &score1, &score2, &score3, &score4 };
	for (int i = 0; i < 5; i++)
	{
		if (*score[i] < 60)
		{
			*score[i] = 60;
		}
		int a = *score[i];
		avg += a;
	}
	printf("��� ���� : %d", avg / 5);

	
}