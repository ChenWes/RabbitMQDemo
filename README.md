## 开始之前
需要使用Docker Compose运行一个RabbitMQ服务器
docker-compose-rabbitmq-test.yml文件内容
```
version: '3'

services:
  
  rabbitmq:
    image: rabbitmq:management
    restart: always
    ports:
      - 5671:5671
      - 5672:5672
      - 4369:4369
      - 15671:15671
      - 15672:15672
      - 25672:25672
    hostname: rabbit
    environment:
      RABBITMQ_DEFAULT_VHOST: /
      RABBITMQ_DEFAULT_USER: admin
      RABBITMQ_DEFAULT_PASS: admin123  
```