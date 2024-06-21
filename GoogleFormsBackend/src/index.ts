import express from 'express';
import bodyParser from 'body-parser';
import cors from 'cors';
import pingRoute from './routes/ping';
import submitRoute from './routes/submit';
import readRoute from './routes/read';
import updateRoute from './routes/update'
import deleteRoute from './routes/delete'
import searchRoute from './routes/search'

const app = express();
const port = 3000;

app.use(cors());
app.use(bodyParser.json());

app.use('/ping', pingRoute);
app.use('/submit', submitRoute);
app.use('/read', readRoute);
app.use('/update', updateRoute);
app.use('/delete', deleteRoute);
app.use('/search', searchRoute);

app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});
