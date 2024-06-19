import pytest, os, sys
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))
from main import app, db, Admin

@pytest.fixture
def client():
    app.config['TESTING'] = True
    app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///:memory:'
    client = app.test_client()

    with app.app_context():
        db.create_all()
        return client
    

def test_validate_success(client):
    response = client.post('/validate', json={
        "username": "admin",
        "password": "test123"
    })
    assert response.status_code == 200
    assert 'Bearer' in response.json
    assert response.json['Bearer'] == 'THISISABEARERTOKEN'


def test_validate_failure(client):
    response = client.post('/validate', json={
        "username": "admin",
        "password": "notpassword"
    })
    assert response.status_code == 401
    assert 'error' in response.json


def test_validate_no_user(client):
    response = client.post('/validate', json={
        "username": "notadmin",
        "password": "test123"
    })
    assert response.status_code == 401
    assert 'error' in response.json


def test_validate_invalid_input(client):
    response = client.post('/validate', json={
        "username": "admin"
    })
    assert response.status_code == 400
    assert 'error' in response.json