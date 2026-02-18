#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
sum matrix

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

int sum_matrix(int your_matrix[3][3],int row ,int colum){
    int sum=0;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            sum+=your_matrix[i][y];
        }
    }
    return sum;
}
int main(){
    int  matrix[3][3];
    full_matrix(matrix,3,3);
    cout<<"this is random matrix\n";
    print_matrix(matrix,3,3);

    cout<<"sum of matrix is :"<<sum_matrix(matrix,3,3);

}