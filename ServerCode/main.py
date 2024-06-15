#!/usr/bin/python3

from flask import Flask, request, jsonify
import json
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy.exc import IntegrityError
from types import SimpleNamespace

app = Flask(__name__)

app.config['SQLALCHEMY_DATABASE_URI'] = 'mysql+mysqlconnector://rk00057:xgfUVvOewU@venerable.pdx1-mysql-a7-5b.dreamhost.com:3306/rk00057'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)

# Class for represeting the objects in the table
class DistrictBookmarks(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(255), nullable=False)
    url = db.Column(db.String(2083), nullable=False)

    def __init__(self, title, url):
        self.name = title
        self.url = url

    def to_dict(self):
        return {
            'id': self.id,
            'name': self.name,
            'url': self.url
        }

# Create the database table
with app.app_context():
    db.create_all()

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=8081)