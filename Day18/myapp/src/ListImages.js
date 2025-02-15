import { useState } from "react";
import Img1 from "./Images/s1.jpg";
import Img2 from "./Images/s2.jpg";
import Img3 from "./Images/s3.jpg";
import Img4 from "./Images/s4.jpg";
import { Container, Button, Row, Col, Card } from "react-bootstrap";
import "./styles/listimages.css";

export default function ListImages() {
  const [showlist, setImgs] = useState(false);
  const Images = [Img1, Img2, Img3, Img4];

  return (
    <Container className="text-center mt-4">
      <Button variant="primary" className="custom-btn" onClick={() => setImgs(!showlist)}>
        {showlist ? "Hide Images" : "Show Images"}
      </Button>
      {showlist && (
        <Row className="mt-3">
          {Images.map((item, index) => (
            <Col key={index} md={3}>
              <Card className="image-card shadow-lg">
                <Card.Img src={item} className="rounded" />
              </Card>
            </Col>
          ))}
        </Row>
      )}
    </Container>
  );
}
