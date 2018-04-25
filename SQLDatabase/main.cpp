#include <QCoreApplication>
#include <QFile>
#include <QStringList>
#include <QDebug>
#include <QtSql>
#include <QStandardItem>
#include <QStandardItemModel>
#include <ctime>
#include <iostream>
#include <cstdio>
using namespace std;

void uploadV1();

int main()
{

    qDebug() <<"start";
    clock_t start;
    double duration;

    start = clock();
    QSqlDatabase db;
    db = QSqlDatabase::addDatabase("QSQLITE");
        db.setDatabaseName("C:/Users/admin/Desktop/cameraDatabase.sqlite");

        if(!db.open())
        {
            qDebug() <<"problem opening the database";
        }

        QString query = "CREATE TABLE testtable ("
                "Timestamp Integer,"
                "Model Integer,"
                "Left Integer,"
                "Right Integer,"
                "Top Integer,"
                "Bottom Integer);";

        QSqlQuery qry;

        if(!qry.exec(query))
        {
            qDebug()<<"error creating table";
        }


    uploadV1();

    duration = (clock() - start) / (double) CLOCKS_PER_SEC;

    cout<<"printf: "<< duration<< '\n';
    qDebug() <<"end";

}

void uploadV1()
{


    QFile file("c:/Users/admin/Desktop/Testlog2.csv");

    if(!file.open(QIODevice::ReadOnly))
    {
        qDebug()<<"error reading file";
    }


        QSqlQuery que;
        QTextStream ts (&file);

        while(!ts.atEnd())
        {
            QString req = "INSERT INTO testtable Values(";
            QStringList line = ts.readLine().split(',');

            for (int i=0; i<line.length();++i){
                req.append(line.at(i));
                req.append(",");
            }
            req.chop(1);
            req.append(");");
            que.exec(req);
        }
        file.close();
}

