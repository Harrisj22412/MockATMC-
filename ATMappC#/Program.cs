//using System;
<iostream>
//namespace ATMappC_
using namespace std;
system("cls")

void showMenu(){
    cout << ***********Menu******** << end1;
    cout << "1. Check Balance" << end1;
    cout << "2. Deposit" << end1;
    cout << "3. Withdraw" << end1;
    cout << "4. Exit" << end1;
    cout << ******************* << end1;
}

int main()
{
    //check balance, deposit, withdraw, show menu
    int option;
    double balance = 500;


    showMenu();
    cout << "Option: ";
    cin >> option;

    do{
    switch(option){
        case 1: cout << "Balance is: " <<balance <<"$" << end1; 
        break;
        case 2: cout << "Deposit amount:";
        double depositAmount;
        cin >> depositAmount;
        balance += depositAmount; 
        break;
        case 3:cout << "Withdraw amount";
        double withdrawAmount;
        cin >> withdrawAMount;
        if(withdrawAMount <= balance)
            balance -= withdrawAMount;
        else
            cout << "Not enough money" << end1;
        break;

        }
    } while (option !=4);
    system("pause > 0");
}








