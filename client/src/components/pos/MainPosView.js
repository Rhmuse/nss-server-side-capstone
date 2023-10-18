import { Button, Col, Row } from 'react-bootstrap';

const MainPosView = () => {
    return (
        <>
            <Row>
                <Col><Button>0</Button></Col>
                <Col><Button>1</Button></Col>
                <Col><Button>2</Button></Col>
                <Col><Button>3</Button></Col>
                <Col><Button>4</Button></Col>
                <Col><Button>5</Button></Col>
                <Col><Button>6</Button></Col>
                <Col><Button>7</Button></Col>
                <Col><Button>8</Button></Col>
                <Col><Button>9</Button></Col>
            </Row>
            <Row>
                <Col><Button>Main</Button></Col>
                <Col><Button>Sides</Button></Col>
                <Col><Button>Drinks</Button></Col>
            </Row>
            <Row>
                <Col>
                    <Row><Button>S</Button></Row>
                    <Row><Button>M</Button></Row>
                    <Row><Button>L</Button></Row>
                </Col>
                <Col>
                    <Row></Row>
                    <Row></Row>
                </Col>
                <Col>
                    <Row><Button>Here/ToGo</Button></Row>
                    <Row><Button>Cancel Order</Button></Row>
                    <Row><Button>Admin Tools</Button></Row>
                </Col>
            </Row>
            <Row>
                <Col>
                    <Row><Button>Burger Modify</Button></Row>
                    <Row><Button>Delete</Button></Row>
                </Col>
                <Col></Col>
                <Col><Button>Complete Order</Button></Col>
            </Row>
        </>
    )
}

export default MainPosView;