import express, { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbPath = path.resolve(__dirname, '../db.json'); 

router.get('/', (req: Request, res: Response) => {
    try {
        
        const data = fs.readFileSync(dbPath, 'utf-8');
        const submissions = JSON.parse(data);
    
        const {email} = req.query;
        

        
        const submission = submissions.find((submission: any) => submission.email === email);
        

        if (submission) {
            
            res.json(submission);
        } else {
            
            res.status(404).json({ error: 'Submission not found' });
        }
    } catch (error) {
        console.error('Error searching submission:', error);
        res.status(500).json({ error: 'Failed to search submission' });
    }
});

export default router;
