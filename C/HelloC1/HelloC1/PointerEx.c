#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int main() {
	// 1. 5개의 성적을 입력받고 순회한다 -> 배열로 받기
	int score[5];
	int* pscore = score;
	for (int i = 0; i < 5; i++)
	{
		// printf("성적을 입력하세요\n");
		// scanf("%d", *pscore[i]);
		scanf("%d", pscore+i);
		// pscore : pscore의 시작 주소(일반 배열도 그럼)
		// pscore 주소값이 1000이라 가정하면
		// pscore + i*(int의 바이트(4))
		// 따라서 pscore 배열의 주소값은 1000, 1004, 1008, 1012, 1016
	}

	// 2. 배열의 값 순회하며, 60 아래의 값을 60으로 수정
	for (int i = 0; i < 5; i++)
	{
		if (*(pscore + i) < 60)
		{
			*(pscore + i) = 60;
		}
		printf("그냥 값 : %d \n", pscore + i);
		printf("* 값 : %d \n", *(pscore + i));

	}

	// 3. 5개의 성적에 대해서 평균값 구하기
	double result = 0;
	for (int i = 0; i < 5; i++)
	{
		int temp = *(pscore + i);
		result += temp;
		printf("result값 : %d \n", result);
	}
	printf("평균값 : %.1f", result / 5);
}