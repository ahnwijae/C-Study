#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int main() {
	// 1. 5���� ������ �Է¹ް� ��ȸ�Ѵ� -> �迭�� �ޱ�
	int score[5];
	int* pscore = score;
	for (int i = 0; i < 5; i++)
	{
		// printf("������ �Է��ϼ���\n");
		// scanf("%d", *pscore[i]);
		scanf("%d", pscore+i);
		// pscore : pscore�� ���� �ּ�(�Ϲ� �迭�� �׷�)
		// pscore �ּҰ��� 1000�̶� �����ϸ�
		// pscore + i*(int�� ����Ʈ(4))
		// ���� pscore �迭�� �ּҰ��� 1000, 1004, 1008, 1012, 1016
	}

	// 2. �迭�� �� ��ȸ�ϸ�, 60 �Ʒ��� ���� 60���� ����
	for (int i = 0; i < 5; i++)
	{
		if (*(pscore + i) < 60)
		{
			*(pscore + i) = 60;
		}
		printf("�׳� �� : %d \n", pscore + i);
		printf("* �� : %d \n", *(pscore + i));

	}

	// 3. 5���� ������ ���ؼ� ��հ� ���ϱ�
	double result = 0;
	for (int i = 0; i < 5; i++)
	{
		int temp = *(pscore + i);
		result += temp;
		printf("result�� : %d \n", result);
	}
	printf("��հ� : %.1f", result / 5);
}