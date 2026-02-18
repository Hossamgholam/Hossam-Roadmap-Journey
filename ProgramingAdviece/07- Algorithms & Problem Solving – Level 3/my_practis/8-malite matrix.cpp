#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number 
full matrix
print matrix;

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
        if(your_matrix[i][y]<10){
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        else{

               cout<<your_matrix[i][y]<<"\t";
        }
            
        }
        cout<<endl;
    }
}
void multi_matrix(int your_matrix1[3][3],int your_matrix2[3][3],int your_matrix_result[3][3],int row,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix_result[i][y]=your_matrix1[i][y]*your_matrix2[i][y];
        }
    }
}
int main(){
    srand(time(0));
    int matrix1[3][3],matrix2[3][3],matrix_result[3][3];

    full_matrix(matrix1,3,3);
    full_matrix(matrix2,3,3);

    cout<<"the random number in matrix1\n";
    print_matrix(matrix1,3,3);
    cout<<"the random number in matrix2\n";
    print_matrix(matrix2,3,3);

    cout<<"the result matrix is\n";
    multi_matrix(matrix1,matrix2,matrix_result,3,3);
    print_matrix(matrix_result,3,3);

   
}