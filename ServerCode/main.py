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

# Create the database table
with app.app_context():
    db.create_all()

# Route gets all pings from table
@app.route('/get_pings', methods=['GET'])
def get_pings():
    pings = BBBPing.query.all()
    pings_list = [ping.to_dict() for ping in pings]
    return jsonify(pings_list), 200

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=8080)