import express, { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbPath = path.resolve(__dirname, '../db.json'); 


router.use(express.json());


router.delete('/', (req: Request, res: Response) => {
    try {
        
        const data = fs.readFileSync(dbPath, 'utf-8');
        const submissions = JSON.parse(data);

        
        const { index } = req.body;

        
        if (typeof index !== 'number' || index < 0 || index >= submissions.length) {
            return res.status(400).json({ error: 'Invalid index' });
        }

        submissions.splice(index, 1);

        fs.writeFileSync(dbPath, JSON.stringify(submissions, null, 2));

        res.json({ success: true });
    } catch (error) {
        console.error('Error deleting submission:', error);
        res.status(500).json({ error: 'Failed to delete submission' });
    }
});

export default router