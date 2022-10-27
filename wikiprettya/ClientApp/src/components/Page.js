import React, {
    Component 
}
from 'react'; 

import {
    Container, 
    Row, 
    Col, 
    Card ,
}from 'react-bootstrap';


export class Page extends Component { 


    render(){ 
        return( 
            <Container>
                <Row>
                    <Col xs={2}>
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
                    </Col> 
                    <Col xs={7}>

                        <h2>Raleigh, North Carolina</h2>
                        <hr/>
                        <small>info from Wikipedia</small>

                        <br/>
                        <br/>
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
                            Right info pane
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