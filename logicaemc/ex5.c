#include <stdio.h>
int main(){
	//usando o continue para pular o 5
for(int i=0;i<=10;i++){
	if(i==5){
		continue;
	}
	printf("%d",i);
}
return 0;
}