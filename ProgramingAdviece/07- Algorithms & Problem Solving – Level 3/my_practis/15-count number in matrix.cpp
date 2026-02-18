#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
read number;
count number;*

*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,10);
        }
    }
}

void print_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
        
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        cout<<endl;
    }
}

int read_number(){
    int number;
    do{
    cout<<"please inter number you wante to count:";cin>>number;

    }while(number<0||number>10);
    return number;
}

int count(int your_matrix[3][3],int row,int colum,int number){
    int counter=0;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]==number){
                counter++;
            }
        }
    }
    return counter;
}
int main(){
    int matrix[3][3]={{9,0,0},{0,9,0},{0,0,9}};
    full_matrix(matrix,3,3);
    cout<<"this is matrix\n";
    print_matrix(matrix,3,3);

    int number=read_number();
    printf("number %0d count int matrix %0d\n",number,count(matrix,3,3,number));
   

}
