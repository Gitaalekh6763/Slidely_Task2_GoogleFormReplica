import { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbPath = path.resolve(__dirname, '../db.json');

router.post('/', (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;

  if (!name || !email || !phone || !github_link || !stopwatch_time) {
    return res.status(400).json({ error: 'All fields are required' });
  }

  const newSubmission = { name, email, phone, github_link, stopwatch_time };

  fs.readFile(dbPath, (err, data) => {
    if (err) throw err;

    const submissions = JSON.parse(data.toString());
    submissions.push(newSubmission);

    fs.writeFile(dbPath, JSON.stringify(submissions, null, 2), (err) => {
      if (err) throw err;
      res.json({ success: true });
    });
  });
});

export default router;
