import React, {
    Component 
}
from 'react'; 

import {
    Container, 
    Row, 
    Col, 
    Card ,
    ListGroup
}from 'react-bootstrap';


export class Page extends Component { 


    render(){ 
        return( 
            <Container>
                <Row>
                    {/* <Col xs={2}>
                        <Card>
                            Left Nav 
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>
                        </Card>
                    </Col>  */}
                    <Col xs={9}>

                        <h2>Raleigh, North Carolina</h2>
                        <hr/>
                        <small>info from Wikipedia</small>

                        <br/>
                        <br/>

                        <p>
                            Raleigh (/ˈrɑːli/; RAH-lee)[6] is the capital of the state of North Carolina and the seat of Wake County in the United States. It is the second-most populous city in North Carolina, after Charlotte, tenth-most populous city in the Southeast, 41st-most populous city in the U.S., and the largest city of the Research Triangle metro area. Raleigh is known as the "City of Oaks" for its many oak trees, which line the streets in the heart of the city.[7] The city covers a land area of 147.6 sq mi (382 km2). The U.S. Census Bureau counted the city's population as 474,069 in 2020.[8] It is one of the fastest-growing cities in the nation.[9][10] The city of Raleigh is named after Sir Walter Raleigh, who established the lost Roanoke Colony in present-day Dare County.
                        </p>
                        <p>
                            Raleigh is home to North Carolina State University (NC State) and is part of the Research Triangle together with Durham (home of Duke University and North Carolina Central University) and Chapel Hill (home of the University of North Carolina at Chapel Hill). The name of the Research Triangle (often shortened to the "Triangle") originated after the 1959 creation of Research Triangle Park (RTP), located in Durham and Wake counties, among the three cities and universities. The Triangle encompasses the U.S. Census Bureau's Raleigh-Durham-Cary Combined Statistical Area (CSA), which had an estimated population of 2,037,430 in 2013.[11] The Raleigh Metropolitan Statistical Area had an estimated population of 1,390,785 in 2019.[12]
                        </p>
                        <p>
                            Most of Raleigh is located within Wake County, with a very small portion extending into Durham County.[13] The towns of Cary, Morrisville, Garner, Clayton, Wake Forest, Apex, Holly Springs, Fuquay-Varina, Knightdale, Wendell, Zebulon, and Rolesville are some of Raleigh's primary nearby suburbs and satellite towns.
                        </p>
                        <p>
                            Raleigh is an early example in the United States of a planned city.[14] Following the American Revolutionary War when the U.S. gained independence, the area was chosen as the site of the state capital in 1788 and incorporated in 1792 as such. The city was originally laid out in a grid pattern with the North Carolina State Capitol in Union Square at the center. During the American Civil War, the city was spared from any significant battle. It fell to the Union in the closing days of the war, and struggled with the economic hardships in the postwar period, related to the reconstitution of labor markets, over-reliance on agriculture, and the social unrest of the Reconstruction Era. The establishment of the Research Triangle Park (RTP) in 1959, helped create tens of thousands of jobs in the fields of science and technology. By the early 21st century, Raleigh had become one of the fastest-growing cities in the United States.
                        </p>




                        <Card>
                            Body 
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>                        
                        <br/>
                        <br/>
                        </Card>
                    </Col> 
                    <Col xs={3}>
                        <Card>
                            <Card.Body>
                                <Card.Title>
                                    Raleigh, North Carolina
                                </Card.Title>
                                <ListGroup variant="flush">
                                    <ListGroup.Item>Clockwise from top left: NC State bell tower, Confederate monument at the North Carolina State Capitol (now removed), houses in Boylan Heights, houses in Historic Oakwood, statue of Sir Walter Raleigh, skyline of the downtown, Fayetteville Street, and the warehouse district</ListGroup.Item>
                                    <ListGroup.Item>Nickname(s): City of Oaks, Raleigh Wood, Oak City</ListGroup.Item>
                                    <ListGroup.Item>
                                        <dl> 
                                            <dt>Country</dt>
                                            <dd>United States</dd>
                                            <dt>State</dt>
                                            <dd>North Carolina</dd>
                                            <dt>Counties</dt>
                                            <dd>Wake, Durham</dd>
                                        </dl>	 	
                                    </ListGroup.Item>
                                </ListGroup>
                                Right info pane

                            </Card.Body>
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>                        
                            <br/>
                            <br/>
                        </Card>
                    </Col> 
                </Row>
            </Container>
        )
    }
}