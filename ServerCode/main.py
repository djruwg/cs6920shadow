#!/usr/bin/python3

from flask import Flask, request, jsonify
import json
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy.exc import IntegrityError
from types import SimpleNamespace
from datetime import datetime

app = Flask(__name__)

app.config['SQLALCHEMY_DATABASE_URI'] = 'mysql+mysqlconnector://rk00057:xgfUVvOewU@venerable.pdx1-mysql-a7-5b.dreamhost.com:3306/rk00057'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)

# Model for creating test table
class BBBPing(db.Model):
    __tablename__ = 'BBBPing'
    
    id = db.Column(db.Integer, primary_key=True, autoincrement=True)
    clientTime = db.Column(db.DateTime, nullable=False)
    serverTime = db.Column(db.DateTime, nullable=False)
    testData = db.Column(db.String(255), nullable=False)

    def __init__(self, clientTime, serverTime, testData):
        self.clientTime = clientTime
        self.serverTime = serverTime
        self.testData = testData

    def to_dict(self):
        return {
            'id': self.id,
            'clientTime': self.clientTime,
            'serverTime': self.serverTime,
            'testData': self.testData
        }
    
# Model for creating Settings object and table
class Settings(db.Model):
    __tablename__ = 'Settings'
    
    start_url = db.Column(db.String(255), nullable=False, primary_key=True)

    def __init__(self, start_url):
        self.start_url = start_url

    def to_dict(self):
        return {
            'start_url': self.start_url
        }

# Create the database table
with app.app_context():
    db.create_all()

# Route gets all pings from table
@app.route('/get_pings', methods=['GET'])
def get_pings():
    pings = BBBPing.query.all()
    pings_list = [ping.to_dict() for ping in pings]
    return jsonify(pings_list), 200

# Route takes the following JSON formart in POST request
"""
{
    "clientTime": "2024-06-15 12:00:00", 
    "serverTime": "2024-06-15 12:01:00", 
    "testData": "Test data"
}
"""
@app.route('/add_ping', methods=['POST'])
def add_ping():
    #testing for getting headers
    headers = request.headers
    print(headers.get('Content-Type'))

    data = request.get_json()
    clientTime = datetime.strptime(data['clientTime'], '%Y-%m-%d %H:%M:%S')
    serverTime = datetime.strptime(data['serverTime'], '%Y-%m-%d %H:%M:%S')
    testData = data['testData']

    new_ping = BBBPing(clientTime=clientTime, serverTime=serverTime, testData=testData)
    db.session.add(new_ping)
    db.session.commit()

    return jsonify(new_ping.to_dict()), 201

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=8080)