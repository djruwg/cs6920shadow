#!/usr/bin/python3

from flask import Flask, request, jsonify
import json
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy.exc import IntegrityError
from types import SimpleNamespace

app = Flask(__name__)

app.config['SQLALCHEMY_DATABASE_URI'] = 'mysql+mysqlconnector://rk00057:xgfUVvOewU@localhost/rk00057'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

db = SQLAlchemy(app)

if __name__ == "__main__":
    app.run(host='0.0.0.0', port=8080)