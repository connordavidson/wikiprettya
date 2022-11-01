import React, { Component } from 'react';

import {
  Card, 
  CardTitle, 
  CardSubtitle, 
  CardBody, 
  CardText, 
  Button ,
  Container, 
  Col, 
  Row, 

  
} from 'reactstrap';
import {HomeCard} from './HomeCard';

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
              <HomeCard title="Raleigh, North Carolina" subtitle="The Capital" link_text="page" link_url="/page" /> 
            </Col>
            <Col>
              <HomeCard title="Charlotte, North Carolina" subtitle="The largest city" link_text="page" link_url="/page" /> 
            </Col>
            <Col>
              <HomeCard title="Wilmington, North Carolina" subtitle="The coastal city" link_text="page" link_url="/page" /> 
            </Col>
          </Row>
          <Row>
            <Col>
              <HomeCard title="Asheville, North Carolina" subtitle="The mountain city" link_text="page" link_url="/page" /> 
            </Col>
            <Col>
              <HomeCard title="Greenville, North Carolina" subtitle="The pirate city" link_text="page" link_url="/page" /> 
            </Col>
            <Col>
              <HomeCard title="Greensboro, North Carolina" subtitle="The piedmont city" link_text="page" link_url="/page" /> 
            </Col>
          </Row>
        </Container>    
      
      </div>

    );
  }
}
