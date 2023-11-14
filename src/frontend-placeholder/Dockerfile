FROM node:21-alpine

WORKDIR /react-app-docker/

COPY public/ /react-app-docker/public
COPY src/ /react-app-docker/src
COPY package.json /react-app-docker/

RUN npm install

EXPOSE 3000

CMD ["npm", "start"]
