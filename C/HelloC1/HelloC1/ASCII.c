#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// C는 프로젝트 단위로 실행(HelloC.c의 main에도 접근하려함)
// HelloC.c > 우클릭 > 속성 > 빌드에서 제외 설정하기
int main() {
	// 아스키코드 : 문자정보 - 숫자를 1:1 대응시켜
	// 컴퓨터와 인간사이에 소통이 가능하게 만든 코드
	//printf("문자로 출력 : %c\n", 'A');
	//printf("숫자로 출력: %d\n", 'A');
	//printf("문자로 출력 : %c\n", 70);
	//printf("문자로 출력 : %c\n", 33);
	//printf("숫자로 출력 : %d\n", '&');
	// 'A' 아스키코드 : 65
	// 'a' 아스키코드 : 97
	// '0' 아스키코드 : 48
	
	// 예제 : 영문자를 입력받고 영문자의 대소문자 바꾸어 출력
	char eng;
	scanf("%c", &eng);
	// 대문자를 입력받은 경우 (65~90)
	if (eng >= 65 && eng <= 90)
	{
		eng += 32;
		printf("대소문자 변경 결과 : %c\n", eng);
	}
	// 소문자를 입력받은 경우 (97~122)
	else if (eng >= 'a' && eng <= 'z')
	{
		eng -= 32;
		printf("대소문자 변경 결과 : %c\n", eng);
	}
}