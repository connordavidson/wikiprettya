import React, { Component } from 'react';

import {
  Card, 
  CardBody, 
  CardTitle, 
  CardSubtitle, 
  CardText, 
  Button ,
  Container, 
  Col, 
  Row, 

  
} from 'reactstrap';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    document.title = 'Home' + ' - Wikiprettya';
    return (
      <div>

        <Container>
          <Row>
            <h1>Wikiprettya</h1>
            <p>This website aims to utilize <a href="https://en.wikipedia.org/wiki/Wikipedia:Database_download" >wikipedia data dumps</a> as a real world data set and to provide a quality backend and frontend app to increase the UI/UX of wikipedia users while continuing to spread the information to the world. </p>
            <br/>
            <br/>
            <hr/>
          </Row>
          <Row>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
          </Row>
          <Row>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
            <Col>
              <Card style={{marginBottom: 25 }}>
                <CardBody>
                  <CardTitle tag="h5">
                    Raleigh, North Carolina
                  </CardTitle>
                  <CardSubtitle
                    className="mb-2 text-muted"
                    tag="h6"
                  >
                    El Capital
                  </CardSubtitle>
                  <CardText>
                    <a href="/page">Page</a>
                  </CardText>
                </CardBody>
              </Card>
            </Col>
          </Row>
        </Container>

        {/* <div>
          <Card>
            <CardBody>
              <CardTitle tag="h5">
                wikiprettya
              </CardTitle>
              <CardSubtitle
                className="mb-2 text-muted"
                tag="h6"
              >
                wikipedia is pretty ugly. let's change that.
              </CardSubtitle>
              <CardText>
                Some quick example text to build on the card title and make up the bulk of the card's content.
              </CardText>
              <Button>
                Button
              </Button>
            </CardBody>
          </Card>
        </div> */}
      
      
      </div>



    );
  }
}
