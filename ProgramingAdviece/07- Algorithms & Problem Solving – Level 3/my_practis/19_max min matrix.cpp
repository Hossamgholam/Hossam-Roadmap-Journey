#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
max min matrix

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

int max_number(int your_matrix[3][3],int row,int colum){
    int max_number=INT_MIN;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]>max_number){
                max_number=your_matrix[i][y];
            }
        }
    }
    return max_number;
}

int min_number(int your_matrix[3][3],int row,int colum){
    int min_number=INT_MAX;
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(your_matrix[i][y]<min_number){
                min_number=your_matrix[i][y];
            }
        }
    }
    return min_number;
}

int main(){
     int matrix[3][3];
    cout<<"this is random number matrix\n";
    full_matrix(matrix,3,3);
    print_matrix(matrix,3,3);

    cout<<"the max number in matrix is:"<<max_number(matrix,3,3)<<endl;
    cout<<"the min number in matrix is:"<<min_number(matrix,3,3);
}