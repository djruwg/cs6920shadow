import pytest, os, sys
sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))
from main import app, db, Settings

@pytest.fixture
def client():
    app.config['TESTING'] = True
    app.config['SQLALCHEMY_DATABASE_URI'] = 'mysql+mysqlconnector://rk00057:xgfUVvOewU@venerable.pdx1-mysql-a7-5b.dreamhost.com:3306/rk00057'
    client = app.test_client()

    with app.app_context():
        db.create_all()
        return client

def test_get_settings(client):
    response = client.get('/settings')

    assert response.status_code == 200
    assert response.json['start_url'] is not None