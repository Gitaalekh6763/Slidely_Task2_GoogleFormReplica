import express, { Router, Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const router = Router();
const dbPath = path.resolve(__dirname, '../db.json'); 

router.put('/', (req: Request, res: Response) => {
    try {
    
        const data = fs.readFileSync(dbPath, 'utf-8');
        const submissions = JSON.parse(data);

        
        const submissionId = req.params.id;
        const updatedSubmission = req.body;

        
        if (!updatedSubmission || typeof updatedSubmission !== 'object') {
            return res.status(400).json({ error: 'Invalid submission data' });
        }

    
        const index = submissions.findIndex((submission: any) => submission.id === submissionId);
        if (index !== -1) {
            submissions[index] = updatedSubmission;

            fs.writeFileSync(dbPath, JSON.stringify(submissions, null, 2));

            res.json({ success: true });
        } else {
            res.status(404).json({ error: 'Submission not found' });
        }
    } catch (error) {
        console.error('Error updating submission:', error);
        res.status(500).json({ error: 'Failed to update submission' });
    }
});

export default router;
