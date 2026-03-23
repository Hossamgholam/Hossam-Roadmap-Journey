#pragma once
#include<iostream>
#include<string>
#include"clsDate.h"
#include<queue>
#include<stack>
using namespace std;

#pragma region description
//
///*
// * Class Name: clsQueueLine
// * ------------------------
// * This class simulates a simple queueing system
// * like the one used in banks, hospitals, or service centers.
// *
// * Features:
// * - Issues new tickets with unique numbers and date/time.
// * - Keeps track of waiting clients and served clients.
// * - Allows serving the next client in the queue.
// * - Provides information about the queue (prefix, total tickets, served, waiting).
// * - Can display tickets in different formats:
// *     * From right-to-left  (first issued → last issued).
// *     * From left-to-right  (last issued → first issued).
// *     * Detailed info for each ticket (time, waiting clients, expected waiting time).
// *
// * Usage:
// * 1. Create an object with prefix and average serving time:
// *        clsQueueLine q("A", 5);   // Prefix A, average 5 minutes per client
// *
// * 2. Issue tickets:
// *        q.issueTicket();
// *        q.issueTicket();
// *
// * 3. Print queue info:
// *        q.printInfo();
// *
// * 4. Serve clients:
// *        q.serveNextClient();
// *
// * 5. Print all tickets or display in line:
// *        q.printTicketsLineRTL();
// *        q.printTicketsLineLTR();
// *        q.printAllTickets();
// *
// * Inner Class: clsTicket
// * -----------------------
// * Represents a single ticket in the queue.
// * Each ticket stores:
// * - Prefix + number (e.g., A1, A2, …).
// * - Date and time when issued.
// * - Number of waiting clients before it.
// * - Expected waiting time (based on average service time).
// */
#pragma endregion

class clsQueueLine
{


private:
	string _prefix = "";
	int _averageServedTime = 0;
	int _totalTickets = 0;
	class clsTicket {
	private:
		string _prefix;
		int _averageServedTime;
		//total number of ticket get from constractor
		int _numberOfTicket = 0;
		string _ticketDateTime = "";
		//number of client wating in queue also get from constactor
		int _watingClient = 0;
		//wating time that client waite in queue
		int _expectedWatingTime = 0;


	public:
		clsTicket(string prefix, int averageTime,
			int numberTicket, int watingCleint) {
			_prefix = prefix;
			_averageServedTime = averageTime;
			_numberOfTicket = numberTicket;
			_ticketDateTime = clsDate::getSystemDateTimeString();
			_watingClient = watingCleint;
		}
		string prefix() {
			return _prefix;
		}
		int averageServedTime() {
			return _averageServedTime;
		}
		int numberOfTicket() {
			return _numberOfTicket;
		}
		//to get number of ticke after add prefix to number
		string fullNumber() {
			return _prefix + to_string(_numberOfTicket);
		}
		string ticketDateTime() {
			return _ticketDateTime;
		}
		int watingClient() {
			return _watingClient;
		}
		int expectedServedTime() {
			return _watingClient * _averageServedTime;
		}

			void print() {
				cout << "\n____________________________";
				cout << "\n         " << fullNumber() << "           \n";
				cout << "\n" <<_ticketDateTime ;
				cout << "\nWating clients=" << _watingClient;
				cout << "\nserve tim in";
				cout << "\n"<<expectedServedTime()<< "munites";
				cout << "\n____________________________\n";
			}
	};
public:
	queue<clsTicket> qTickets;
	clsQueueLine(string perfix, int wating) {
		_prefix = perfix;
		_averageServedTime = wating;
	}
    void issueTicket() {
		_totalTickets++;
		clsTicket ticket(_prefix, _averageServedTime
			, _totalTickets, qTickets.size());
		qTickets.push(ticket);
	}
	int watingClient() {
		return qTickets.size();
	}
	int servedClient() {
		return _totalTickets - watingClient();
	}
	string whoIsNext() {
		if (qTickets.empty()) {
			return "\nno ticket  left\n";
		}
		else {
			return qTickets.front().fullNumber();
		}
	}
	bool serveNextClient() {
 	   if(!qTickets.empty()){
		qTickets.pop();
		return true;
 	   }
	   return false;
	}
	void printInfo() {
		
		cout << "\t\t\t\t_________________________\n";
		cout << "\t\t\t\t          queue info       \n";
		cout << "\t\t\t\t___________________________\n";
		cout << "\t\t\t\tprefix         =" << _prefix;
		cout << "\n\t\t\t\ttotal tickets  =" << _totalTickets;
		cout << "\n\t\t\t\tserved clients =" << servedClient();
		cout << "\n\t\t\t\twating clients =" << watingClient();
		cout << "\n\t\t\t\t____________________________\n";
	}
    void printTicketsLineRTL() {
		if (qTickets.empty()) {
			cout << "ticket:no ticket\n";
			return;
		}
		else {
			cout << "ticket:";
		    queue<clsTicket>qTicketsTim=qTickets;
		    while (!qTicketsTim.empty()) {
		    	cout<< qTicketsTim.front().fullNumber(); cout << "<--";
		    	qTicketsTim.pop();
		    }
		}
	}
	void printTicketsLineLTR() {
		if (qTickets.empty()) {
			cout << "ticket:no ticket\n";
			return;
		}
		else {
			cout << "ticket:";
			queue < clsTicket > qTicketsTim = qTickets;
		    stack<clsTicket>sTickets;
		    while (!qTicketsTim.empty()) {
		    	sTickets.push(qTicketsTim.front());
		    	qTicketsTim.pop();
		    }
		    while (!sTickets.empty()) {
		    	cout << sTickets.top().fullNumber() << "-->";
		    	sTickets.pop();
		    }
		}
		
	}
	void printAllTickets() {
		cout << "\n\t tickets\n";
	    cout << "\n____________________________\n";
		if (qTickets.empty()) {
			cout << "NO tickets\n";
		} 
		else{
		    queue<clsTicket>qTicketsTim = qTickets;
		    while (!qTicketsTim.empty()) {
		    	qTicketsTim.front().print();
		    	cout << endl;
		    	qTicketsTim.pop();
		    }
		}
		
	}

};

