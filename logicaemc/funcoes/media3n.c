#include <stdio.h>
float mediatres(float x, float y, float z);
int main()
{
	float x, y, z;
	printf("Informe a n1 : ");
	scanf("%f",&x);
	printf("Informe a n2 : ");
	scanf("%f",&y);
	printf("Informe a n3 : ");
	scanf("%f",&z);
	printf("A media deu: %.2f",mediatres(x,y,z));
	return 0;
}
float mediatres(float x, float y, float z)
{
	return (x+y+z)/3;
}
